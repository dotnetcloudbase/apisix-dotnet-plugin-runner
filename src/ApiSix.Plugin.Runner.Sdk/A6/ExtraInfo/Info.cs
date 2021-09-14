using FlatSharp;
using System;

namespace ApiSix.Plugin.Runner.Sdk.A6.ExtraInfo
{
    public class Info : FlatBufferUnion<Var, ReqBody>
    {
        public enum ItemKind : byte
        {
            Var = 1,
            ReqBody = 2,
        }

        public ItemKind Kind => (ItemKind)base.Discriminator;

        public Info(Var value) : base(value)
        {

        }

        public Var Var => base.Item1;

        public Info(ReqBody value) : base(value)
        {

        }

        public ReqBody ReqBody => base.Item2;

        public new TReturn Switch<TState, TReturn>(
            TState state,
            Func<TState, TReturn> caseDefault
            , Func<TState, Var, TReturn> caseVar
            , Func<TState, ReqBody, TReturn> caseReqBody
        ) => base.Switch<TState, TReturn>(state, caseDefault, caseVar, caseReqBody);
        public new TReturn Switch<TReturn>(
            Func<TReturn> caseDefault
            , Func<Var, TReturn> caseVar
            , Func<ReqBody, TReturn> caseReqBody
        ) => base.Switch<TReturn>(caseDefault, caseVar, caseReqBody);
        public new void Switch<TState>(
            TState state,
            Action<TState> caseDefault
            , Action<TState, Var> caseVar
            , Action<TState, ReqBody> caseReqBody
        ) => base.Switch<TState>(state, caseDefault, caseVar, caseReqBody);
        public new void Switch(
            Action caseDefault
            , Action<Var> caseVar
            , Action<ReqBody> caseReqBody
        ) => base.Switch(caseDefault, caseVar, caseReqBody);
    }
}
