using FlatSharp;
using System;

namespace ApiSix.Plugin.Runner.Sdk.A6.HTTPReqCall
{
    public class Action : FlatBufferUnion<Stop, Rewrite>
    {
        public enum ItemKind : byte
        {
            Stop = 1,
            Rewrite = 2,
        }


        public ItemKind Kind => (ItemKind)base.Discriminator;

        public Action(Stop value) : base(value)
        {
            checked
            { }
        }

        public Stop Stop => base.Item1;

        public Action(Rewrite value) : base(value)
        {
            checked
            { }
        }

        public Rewrite Rewrite => base.Item2;
        public new TReturn Switch<TState, TReturn>(
            TState state,
            Func<TState, TReturn> caseDefault
            , Func<TState, Stop, TReturn> caseStop
            , Func<TState, Rewrite, TReturn> caseRewrite
        ) => base.Switch<TState, TReturn>(state, caseDefault, caseStop, caseRewrite);
        public new TReturn Switch<TReturn>(
            Func<TReturn> caseDefault
            , Func<Stop, TReturn> caseStop
            , Func<Rewrite, TReturn> caseRewrite
        ) => base.Switch<TReturn>(caseDefault, caseStop, caseRewrite);
        public new void Switch<TState>(
            TState state,
            Action<TState> caseDefault
            , Action<TState, Stop> caseStop
            , Action<TState, Rewrite> caseRewrite
        ) => base.Switch<TState>(state, caseDefault, caseStop, caseRewrite);

        public new void Switch(
            System.Action caseDefault
            , Action<Stop> caseStop
            , Action<Rewrite> caseRewrite
        ) => base.Switch(caseDefault, caseStop, caseRewrite);
    }
}
