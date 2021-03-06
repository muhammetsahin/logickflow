using System;

namespace Logickflow.Core
{
    internal class Action:IAction
    {
        private readonly int _targetActivityId;
        private readonly OperationCode _operation;

        public Action(OperationCode operation, int targetActivityId)
        {
            _targetActivityId = targetActivityId;
            _operation = operation;
        }

        public OperationCode OperationCode { get { return _operation; }}

        public IActivityTemplate Transit { get; set; }

        public int TargetActivityId { get { return _targetActivityId;} }
    }
}