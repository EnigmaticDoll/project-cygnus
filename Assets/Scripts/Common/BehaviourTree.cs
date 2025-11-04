using System;
using System.Collections.Generic;

// LibMagic is just a placeholder for my implementation!
// LibMagic is an abbreviation of LIBER MAGICAE which means a book about magic.
namespace LibMagic
{

    public sealed class BehaviourTreeNode
    {
        public enum NodeType
        {
            Selector,
            Sequence,
            Action
        }

        public enum EvaluationStatus
        {
            Failure,
            Ongoing,
            Success
        }
        NodeType type;
        Func<EvaluationStatus> onEvaluation;
        List<BehaviourTreeNode> children;
        public EvaluationStatus Evaluate()
        {
            switch(type)
            {
                case NodeType.Selector:
                    foreach (BehaviourTreeNode child in children)
                    {
                        EvaluationStatus status = child.Evaluate();
                        if (EvaluationStatus.Failure != status) return status;
                    }
                    return EvaluationStatus.Failure;
                case NodeType.Sequence:
                    foreach (BehaviourTreeNode child in children)
                    {
                        EvaluationStatus status = child.Evaluate();
                        if (EvaluationStatus.Success != status) return status;
                    }
                    return EvaluationStatus.Success;
                case NodeType.Action:
                    return Evaluate();
                default:
                    throw new NotImplementedException();
            }
        }

        public BehaviourTreeNode(
            NodeType type,
            Func<EvaluationStatus> onEvaluation,
            List<BehaviourTreeNode> children)
        {
            this.type = type;
            this.onEvaluation = onEvaluation;
            this.children = children;
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