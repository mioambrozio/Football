using MIO.Football.Domain.Extensions;
using NUnit.Framework;
using System;

namespace Tests
{
    public class UtilsTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void SearchMinLenght()
        {
            try
            {
                Assert.False(Utilitarios.SearchEmptyOrNullOrDifNumber("125"));
            }
            catch (Exception ex) { throw ex; }
        }

        [Test]
        public void SearchMaxLenght()
        {
            try
            {
                Assert.False(Utilitarios.SearchEmptyOrNullOrDifNumber("1245645"));
            }
            catch (Exception ex) { throw ex; }
        }

        [Test]
        public void SearchEmptyOrNullOrSpace()
        {
            try
            {
                Assert.False(Utilitarios.SearchEmptyOrNullOrDifNumber(" "));
            }
            catch (Exception ex) { throw ex; }
        }

        [Test]
        public void SearchDifNumber()
        {
            try
            {
                Assert.False(Utilitarios.SearchEmptyOrNullOrDifNumber("AbC"));
            }
            catch (Exception ex) { throw ex; }
        }

        [Test]
        public void SearchOK()
        {
            try
            {
                Assert.False(Utilitarios.SearchEmptyOrNullOrDifNumber("2021"));
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
