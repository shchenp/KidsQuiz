using CardHandlers;
using CellHandlers;
using ScriptableObjects;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class GameLifeTimeScope : LifetimeScope
{
    [SerializeField] private CellPrefabs _cellPrefabs;
    
    [SerializeField] private ParticleHandler _particleHandler;

    [SerializeField] private CellGridMaker _cellGridMaker;

    [SerializeField] private TargetCardHandler _targetCard;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterInstance(_cellPrefabs);
        builder.RegisterInstance(_particleHandler);
        builder.RegisterInstance(_cellGridMaker);
        builder.RegisterInstance(_targetCard);

        builder.Register<CellFactory>(Lifetime.Singleton);
    }
}