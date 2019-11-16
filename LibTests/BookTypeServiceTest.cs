using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services.BookTypes;
using Xunit;

namespace LibTests
{
    public class BookTypeServiceTest
    {
        [Fact]
        public async Task AddTest()
        {
            var fakeRepository = Mock.Of<IBookTypeRepository>();
            var service = new BookTypeService(fakeRepository);
            var bookType = new BookType()
            {
                ID = default(Guid),
                Discription = "Discription 1"
            };
            service.Create(bookType);
        }
        [Fact]
        public async Task GetAuthorsTest()
        {
            var bookTypes = new List<BookType>
            {
                new BookType() {
                ID = default(Guid),
                Discription = "Discription 1"
                },
                new BookType() {
                ID = default(Guid),
                Discription = "Discription 2" 
                }
            };


            var fakeRepositoryMock = new Mock<IBookTypeRepository>();
            fakeRepositoryMock.Setup(x => x.getList()).ReturnsAsync(bookTypes);
            var service = new BookTypeService(fakeRepositoryMock.Object);

            var result = await service.GetList();

            Assert.Collection(result, bookType =>
            {
                Assert.Equal("Discription 1", bookType.Discription);
            },
            bookType =>
            {
                Assert.Equal("Discription 2", bookType.Discription);
            });
        }
        [Fact]
        public async Task SearchTest()
        {
            var bookType = new BookType
            {
                ID = default(Guid),
                Discription = "Discription 1"
            };

            var fakeRepositoryMock = new Mock<IBookTypeRepository>();
            fakeRepositoryMock.Setup(x => x.Find(It.IsAny<Guid>())).Returns(bookType);


            var service = new BookTypeService(fakeRepositoryMock.Object);

            var result = service.Get(default(Guid));

            Assert.Equal("Discription 1", result.Discription);

        }
    }
}
