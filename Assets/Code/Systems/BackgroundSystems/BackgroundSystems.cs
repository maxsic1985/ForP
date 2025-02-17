﻿using Leopotam.EcsLite;


namespace MSuhininTestovoe.B2B
{
    public class BackgroundSystems
    {
        public BackgroundSystems(EcsSystems systems)
        {
            systems
                .Add(new BackgroundLoadSystem())
                .Add(new BackGroundInitSystem())
                .Add(new BackgroundBuildSystem())
                .Add(new BackgroundMoveSystem())
                .Add(new BackgroundCheckPositionSystem());
        }
    }
}