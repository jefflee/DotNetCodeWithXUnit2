using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace DemoCode.Tests.CollectionExecutionOrder
{
    //This class is used in assemblyInfo.cs.
    //It doesn't work for me. 
    public class AlphabeticCollectionOrderer : ITestCollectionOrderer
    {
        public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
        {      
            var collectionOrder = testCollections.OrderBy(testCollection => testCollection.DisplayName);

            return collectionOrder;
        }
    }
}
