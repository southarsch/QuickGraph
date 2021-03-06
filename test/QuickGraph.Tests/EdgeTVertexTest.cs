// <copyright file="EdgeTVertexTest.cs" company="Jonathan de Halleux">Copyright http://quickgraph.codeplex.com/</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;

namespace QuickGraph
{
    /// <summary>This class contains parameterized unit tests for Edge`1</summary>
    [TestClass]
    [PexClass(typeof(Edge<>))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EdgeTVertexTest
    {
        /// <summary>Test stub for .ctor(!0, !0)</summary>
        [PexMethod]
        [PexGenericArguments(typeof(int))]
        public Edge<TVertex> Constructor<TVertex>(TVertex source, TVertex target)
        {
            // TODO: add assertions to method EdgeTVertexTest.Constructor(!!0, !!0)
            Edge<TVertex> target01 = new Edge<TVertex>(source, target);
            return target01;
        }

        /// <summary>Test stub for Source</summary>
        [PexMethod]
        [PexGenericArguments(typeof(int))]
        public void SourceGet<TVertex>([PexAssumeUnderTest]Edge<TVertex> target)
        {
            // TODO: add assertions to method EdgeTVertexTest.SourceGet(Edge`1<!!0>)
            TVertex result = target.Source;
        }

        /// <summary>Test stub for Target</summary>
        [PexMethod]
        [PexGenericArguments(typeof(int))]
        public void TargetGet<TVertex>([PexAssumeUnderTest]Edge<TVertex> target)
        {
            // TODO: add assertions to method EdgeTVertexTest.TargetGet(Edge`1<!!0>)
            TVertex result = target.Target;
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        [PexGenericArguments(typeof(int))]
        public string ToString<TVertex>([PexAssumeUnderTest]Edge<TVertex> target)
        {
            // TODO: add assertions to method EdgeTVertexTest.ToString(Edge`1<!!0>)
            string result = target.ToString();
            return result;
        }
    }
}
