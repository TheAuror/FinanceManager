using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FinanceManager.BusinessLayer.CategoryModels;
using FinanceManager.DataLayer;
using FinanceManager.DataLayer.Entities;
using FluentAssertions;
using Moq;
using NUnit.Framework;


namespace FinanceManager.Tests.BusinessLayer
{
    [TestFixture]
    public class CategoryServiceTests
    {
        List<CategoryEntity> _categoryList;
        Mock<ISampleContext> _sampleContextMock;

        [SetUp]
        public void SetUp()
        {
            _categoryList = new List<CategoryEntity>
            {
                new CategoryEntity
                {
                    Id = 0,
                    Name = "Name0"
                },
                new CategoryEntity
                {
                    Id = 1,
                    Name = "Name1"
                },
                new CategoryEntity
                {
                    Id = 2,
                    Name = "Name2"
                }
            };

            _sampleContextMock = new Mock<ISampleContext>();
            var categoryDbSetMock = new Mock<DbSet<CategoryEntity>>();
            categoryDbSetMock.SetDataSource(_categoryList);
            _sampleContextMock.Setup(sampleContext => sampleContext.Categorys).Returns(categoryDbSetMock.Object);           
        }

        [Test]
        public void GetCategorys_ShouldReturnAllCategorys()
        {
            ISampleContext context = _sampleContextMock.Object;
            CategoryService objectUnderTest = new CategoryService(context);

            var result = objectUnderTest.GetCategorys();

            result.Should().NotBeNull();
            result.Should().OnlyContain(e => _categoryList.Any(f => e.Id == f.Id));
            result.Should().OnlyContain(e => _categoryList.Any(f => e.Name == f.Name));
            result.Should().HaveCount(_categoryList.Count);
        }

        [Test]
        public void GetCategory_OnVariousStrings_ShouldReturnTheGoodResults()
        {
            ISampleContext context = _sampleContextMock.Object;
            CategoryService objectUnderTest = new CategoryService(context);

            var result = objectUnderTest.GetCategory("Name");
            var result2 = objectUnderTest.GetCategory("WrongString");

            //result.Should().NotBeNull();
            //result.Should().Be(_categoryList.FirstOrDefault(e => e.Name.Contains("Name")));

            //result2.Should().BeNull();
        }
    }
}