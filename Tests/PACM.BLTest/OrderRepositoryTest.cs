﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BLTest
{
    [TestClass()]
    public class OrderRepositoryTest
    {
        [TestMethod()]
        public void RetrieveOrderDisplayTest()
        {
            // -- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            // -- Act
            var actual = orderRepository.Retrieve(10);


            // -- Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
