using ClinkedIn.Api.DataAccess;
using ClinkedIn.Api.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace ClinkedIn.Test
{
    public class UnitTest1
    {
        [Fact]
        public void getEnemiesByInmateIdReturnsAListOfEnemies()
        {
            // Arrange
            var inmateRepository = new InmateRepository();
            List<Inmate> result = new List<Inmate>();

            // Act
            List<Inmate> inmate1EnemiesFromMethod = inmateRepository.GetEnemiesByInmateId(new Guid("00000000-0000-0000-0000-000000000001"));
            Inmate inmate3 = inmateRepository.GetInmateById(new Guid("00000000-0000-0000-0000-000000000003"));
            Inmate inmate9 = inmateRepository.GetInmateById(new Guid("00000000-0000-0000-0000-000000000009"));
            Inmate inmate12 = inmateRepository.GetInmateById(new Guid("00000000-0000-0000-0000-000000000012"));
            result.Add(inmate3);
            result.Add(inmate9);
            result.Add(inmate12);

            // Assert
            Assert.Equal(inmate1EnemiesFromMethod, result);
        }
    }
}
