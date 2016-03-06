#region License and Terms
// MoreLINQ - Extensions to LINQ to Objects
// Copyright (c) 2016 Sergiy Zinovyev. All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace MoreLinq.Test
{
    /// <summary>
    /// Tests that verify the behavior of the Shuffle operator.
    /// </summary>
    [TestFixture]
    public class SelectTrimmedNotEmptyTests
    {
        /// <summary>
        /// Verify that Shuffle throws an exception if invoked on a <c>null</c> sequence.
        /// </summary>
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSelectTrimmedNotEmptyArgNullException()
        {
            IEnumerable<string> sequenceA = null;
            sequenceA.SelectTrimmedNotEmpty();
        }

        /// <summary>
        /// Verify that Shuffle shuffles source sequence.
        /// </summary>
        [Test]
        public void TestSelectTrimmedNotEmpty()
        {
            string[] source = { "1", null, "2", "", "3" };
            Assert.IsTrue(source.SelectTrimmedNotEmpty().SequenceEqual(Enumerable.Range(1, 3).Select(v => v.ToString())));
        }
    }
}
