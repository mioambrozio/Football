using MIO.Football.Domain.Entities.Standings;
using MIO.Football.Services.Services;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Tests
{
    public class CampeonatoTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void SearchNotExists()
        {
            try
            {
                CampeonatoService _service = new CampeonatoService();
                Task<StandingsEntity> retorno = _service.SearchStandings("202");
                retorno.Wait();
                if (retorno.IsFaulted)
                {
                    Assert.Equals(retorno.IsFaulted, true);
                }
            }
            catch (Exception ex) { throw ex; }
        }

        [Test]
        public void SearchErrorService()
        {
            try
            {
                CampeonatoService _service = new CampeonatoService();
                Task<StandingsEntity> retorno = _service.SearchStandings("flgjkdlsg/gfdgdf");
                retorno.Wait();
                if (retorno.IsFaulted)
                {
                    Assert.Equals(retorno.IsFaulted, true);
                }
            }
            catch (Exception ex) { throw ex; }
            Assert.Pass();
        }

        [Test]
        public void SearchWithOutResults()
        {
            try
            {
                CampeonatoService _service = new CampeonatoService();
                Task<StandingsEntity> retorno = _service.SearchStandings("2021");
                retorno.Wait();
                if (retorno.IsCompletedSuccessfully)
                {
                    Assert.Equals(retorno.Result, null);
                }
            }
            catch (Exception ex) { throw ex; }
        }

        [Test]
        public void SearchSucessResults()
        {
            try
            {
                CampeonatoService _service = new CampeonatoService();
                Task<StandingsEntity> retorno = _service.SearchStandings("2021");
                retorno.Wait();
                if (retorno.IsCompletedSuccessfully)
                {
                    Assert.AreNotEqual(retorno.Result, null);
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}