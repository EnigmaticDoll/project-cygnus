using System;
using System.Collections.Generic;
using static LibMagic.BehaviourTreeNode;
using static Unity.VisualScripting.Metadata;

// LibMagic is just a placeholder for my implementation!
// LibMagic is an abbreviation of LIBER MAGICAE which means a book about magic.
namespace LibMagic
{
        public enum NodeType
        {
            Selector,
            Sequence,
            If,
            While,
            Action
        }

    public abstract class BehaviourTreeNode
    {
        public enum EvaluationStatus
        {
            Failure,
            InProgress,
            Success
        }

        protected Func<EvaluationStatus> onEvaluation;
        protected List<BehaviourTreeNode> children;

        public abstract EvaluationStatus Evaluate();

        //{
        //    isInProgress = true;
        //    switch (type)
        //    {
        //        case NodeType.Selector:
        //            foreach (BehaviourTreeNode child in children)
        //            {
        //                EvaluationStatus status = child.Evaluate();
        //                if (EvaluationStatus.Failure != status)
        //                {
        //                    isInProgress = (EvaluationStatus.InProgress != status);
        //                    return status;
        //                }
        //            }
        //            return EvaluationStatus.Failure;
        //        case NodeType.Sequence:
        //            foreach (BehaviourTreeNode child in children)
        //            {
        //                EvaluationStatus status = child.Evaluate();
        //                if (EvaluationStatus.Success != status) return status;
        //            }
        //            return EvaluationStatus.Success;
        //        case NodeType.If:
        //            if ()
        //            {

        //            }
        //        case NodeType.Action:
        //            return Evaluate();
        //        default:
        //            throw new NotImplementedException();
        //    }
        //}

        //public BehaviourTreeNode(
        //    NodeType type,
        //    Func<EvaluationStatus> onEvaluation,
        //    List<BehaviourTreeNode> children)
        //{
        //    this.type = type;
        //    this.onEvaluation = onEvaluation;
        //    this.children = children;
        //}
    }

    public class BehaviourTreeSelectorNode : BehaviourTreeNode
    {
        public override EvaluationStatus Evaluate()
        {
            foreach (BehaviourTreeNode child in children)
            {
                EvaluationStatus status = child.Evaluate();
                if (EvaluationStatus.Failure != status)
                {
                    isInProgress = (EvaluationStatus.InProgress != status);
                    return status;
                }
                return EvaluationStatus.Failure;
            }
        }
    }

    public class BehaviourTree
    {
        BehaviourTreeNode root;

        public BehaviourTreeNode.EvaluationStatus Evaluate()
        {
            return root.Evaluate();
        }

        public BehaviourTree(BehaviourTreeNode root)
        {
            this.root = root;
        }
    }
}