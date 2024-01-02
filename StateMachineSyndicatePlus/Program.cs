using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var stateMachine = new StateMachineService<GameStateMachineData>();

            stateMachine.Register(new BootstrapState());
            stateMachine.Register(new MainMenuState());

            stateMachine.Enter<BootstrapState>();
            stateMachine.Enter<MainMenuState>();

            Console.WriteLine(stateMachine.Data.Name);
        }
    }

    public class GameStateMachineData
    {
        public string Name = "Kekw";
    }

    public interface IService
    {
    }

    public interface IState : IExitableState
    {
        void Enter();
    }

    public interface IPayloadedState<TPayload> : IExitableState
    {
        void Enter(TPayload payload);
    }

    public interface IPayloadedState<TPayload, TPayload2> : IExitableState
    {
        void Enter(TPayload mainMenuSceneName, TPayload2 nextSceneName);
    }

    public interface IPayloadedState<TPayload, TPayload2, TPayload3> : IExitableState
    {
        void Enter(TPayload payload, TPayload2 payload2, TPayload3 payload3);
    }

    public interface IPayloadedState<TPayload, TPayload2, TPayload3, TPayload4> : IExitableState
    {
        void Enter(TPayload payload, TPayload2 payload2, TPayload3 payload3, TPayload4 payload4);
    }

    public interface IExitableState
    {
        void Exit();
    }

    public interface IStateMachineService : IService
    {
        void Enter<TState>() where TState : class, IState;

        void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadedState<TPayload>;

        void Enter<TState, TPayload, TPayload2>(TPayload payload, TPayload2 payload2) where TState : class, IPayloadedState<TPayload, TPayload2>;

        TState Get<TState>() where TState : class, IExitableState;
    }

    public class StateMachineService<TStateMachineData> : IStateMachineService where TStateMachineData : class
    {
        private IExitableState _activeState;

        public TStateMachineData Data { get; set; }

        public StateMachineService()
        {
            Data = Activator.CreateInstance<TStateMachineData>();
        }

        public void Enter<TState>() where TState : class, IState
        {
            IState state = ChangeState<TState>();
            state.Enter();
        }

        public void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadedState<TPayload>
        {
            ChangeState<TState>().Enter(payload);
        }

        public void Enter<TState, TPayload, TPayload2>(TPayload payload, TPayload2 payload2)
            where TState : class, IPayloadedState<TPayload, TPayload2>
        {
            var state = ChangeState<TState>();
            state.Enter(payload, payload2);
        }

        public TState Get<TState>() where TState : class, IExitableState
        {
            return Implementation<TState>.StateInstance;
        }

        public TState Register<TState>(TState implementation) where TState : IState
        {
            return Implementation<TState>.StateInstance = implementation;
        }

        private TState ChangeState<TState>() where TState : class, IExitableState
        {
            _activeState?.Exit();
            var state = Get<TState>();
            _activeState = state;
            return state;
        }

        private class Implementation<TState>
        {
            public static TState StateInstance;
        }
    }

    public class BootstrapState : IState
    {
        public void Enter()
        {
            Console.WriteLine("Вошли в бутстап");
        }

        public void Exit()
        {
            Console.WriteLine("Вышли из бутстап");
        }
    }

    public class MainMenuState : IState
    {
        public void Enter()
        {
            Console.WriteLine("Вошли в MainMenuState");
        }

        public void Exit()
        {
            Console.WriteLine("Вышли из MainMenuState");
        }
    }
}