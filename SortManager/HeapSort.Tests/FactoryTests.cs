using SortManager.App.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.Tests
{
    public class FactoryTests
    {
        [Test]
        public void WhenGivenBubbleSortString_CreateSortAlgorithm_CreatesBubbleSortInstance()
        {
            Assert.DoesNotThrow(() => Factory.CreateSortAlgorithm("bubblesort")); 
        }

        [Test]
        public void WhenGivenHeapSortString_CreateSortAlgorithm_CreatesHeapSortInstance()
        {
            Assert.DoesNotThrow(() => Factory.CreateSortAlgorithm("heapsort"));
        }

        [Test]
        public void WhenGivenMergeSortString_CreateSortAlgorithm_CreatesMergeSortInstance()
        {
            Assert.DoesNotThrow(() => Factory.CreateSortAlgorithm("mergesort"));
        }

        [Test]
        public void WhenGivenRadixSortString_CreateSortAlgorithm_CreatesRadixSortInstance()
        {
            Assert.DoesNotThrow(() => Factory.CreateSortAlgorithm("radixsort"));
        }

        [Test]
        public void WhenGivenInvalidString_CreateSortAlgorithm_ThrowsArgumentException()
        {
            Assert.That(() => Factory.CreateSortAlgorithm("blablabla"),
                Throws.ArgumentException);
        }

    }
}
