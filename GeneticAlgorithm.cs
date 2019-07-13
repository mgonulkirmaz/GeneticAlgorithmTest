using System;
using System.Collections.Generic;

public class GeneticAlgorithm<T>
{
    public List<DNA<T>> Population { get; private set; }
    public int Generation { get; private set; }
    public float BestFitness { get; private set; }
    public T[] BestDNA { get; private set; }
    public int Elitism;
    private List<DNA<T>> newPopulation;

    private float MutationRate;
    private float fitnessSum;
    private int dnaSize;
    private Func<T> getRandomGene;
    private Func<int, float> fitnessFunction;


    private Random random;

    public GeneticAlgorithm(int populationSize, int dnaSize, Random random, Func<T> getRandomGene, Func<int, float> fitnessFunction, int elitism, float mutationRate = 0.01f)
    {
        this.random = random;
        MutationRate = mutationRate;
        Elitism = elitism;
        this.dnaSize = dnaSize;
        this.getRandomGene = getRandomGene;
        this.fitnessFunction = fitnessFunction;
        Population = new List<DNA<T>>(populationSize);
        newPopulation = new List<DNA<T>>(populationSize);
        BestDNA = new T[dnaSize];
        BestFitness = 0;

        Generation = 1;

        for (int i = 0; i < populationSize; i++)
        {
            Population.Add(new DNA<T>(dnaSize, random, getRandomGene, fitnessFunction, initRandomGene: true));
        }
    }

    public void NewGeneration(int numNewDNA = 0, bool crossoverNewDNA = false)
    {

        int finalCount = Population.Count + numNewDNA;

        if (finalCount <= 0)
        {
            return;
        }

        if (Population.Count > 0)
        {
            CalculateFitness();
            Population.Sort(CompareDNA);
        }
        newPopulation.Clear();

        for (int i = 0; i < Population.Count; i++)
        {
            if (i < Elitism && i < Population.Count)
            {
                newPopulation.Add(Population[i]);
            }
            else if (i < Population.Count || crossoverNewDNA)
            {
                DNA<T> parent1 = ChooseParent();
                DNA<T> parent2 = ChooseParent();

                DNA<T> child = parent1.Crossover(parent2);

                child.Mutate(MutationRate);

                newPopulation.Add(child);
            }
            else
            {
                newPopulation.Add(new DNA<T>(dnaSize, random, getRandomGene, fitnessFunction, initRandomGene: true));
            }
        }

        List<DNA<T>> tmpList = Population;
        Population = newPopulation;
        newPopulation = tmpList;

        Generation++;

    }

    public int CompareDNA(DNA<T> a, DNA<T> b)
    {
        if (a.Fitness < b.Fitness)
        {
            return 1;
        }
        else if (a.Fitness > b.Fitness)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }

    public void CalculateFitness()
    {
        fitnessSum = 0;
        DNA<T> best = Population[0];

        for (int i = 0; i < Population.Count; i++)
        {
            fitnessSum += Population[i].CalculateFitness(i);

            if (Population[i].Fitness > best.Fitness)
            {
                best = Population[i];
            }
        }

        BestFitness = best.Fitness;
        best.Genes.CopyTo(BestDNA, 0);

    } 

    private DNA<T> ChooseParent()
    {
        double randomNumber = random.NextDouble() * fitnessSum;

        for (int i = 0; i < Population.Count; i++)
        {
            if (randomNumber < Population[i].Fitness)
            {
                return Population[i];
            }

            randomNumber -= Population[i].Fitness;
        }

        return Population[0];
    }
}