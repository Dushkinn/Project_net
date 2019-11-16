using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

using WebApplication2.Services.Authors;
using Moq;
using WebApplication2.Models;

namespace LibTests
{
    public class AuthorServiceTest
    {
        [Fact]
        public async Task AddTest()
        {
            var fakeRepository = Mock.Of<IAuthorRepository>();
            var service = new AuthorService(fakeRepository);
            var author = new Author()
            {
                Id = Guid.NewGuid(),
                FullName = "Full Name",
                DOB = DateTime.Now,
                Biography = "Biography"
            };
            service.CreateAuthor(author);
        }
        [Fact]
        public async Task GetAuthorsTest() {
            var movies = new List<Author>
            {
                new Author() {
                      Id = default(Guid),
                FullName = "Full Name 1",
                Biography = "Biography 1"
                },
                new Author() {
                    Id = default(Guid),
                FullName = "Full Name 2",
                Biography = "Biography 2" },
            };


            var fakeRepositoryMock = new Mock<IAuthorRepository>();
            fakeRepositoryMock.Setup(x => x.getList()).ReturnsAsync(movies);
            var service = new AuthorService(fakeRepositoryMock.Object);

            var result = await service.GetAuthors();

            Assert.Collection(result, author =>
            {
                Assert.Equal("Full Name 1", author.FullName);
                Assert.Equal("Biography 1", author.Biography);
            },
            author =>
            {
                Assert.Equal("Full Name 2", author.FullName);
                Assert.Equal("Biography 2", author.Biography);
            });
        }
        [Fact]
        public async Task SearchTest()
        {
            var author = new Author()
            {
                Id = default(Guid),
                FullName = "Full Name 1",
                Biography = "Biography 1"
            };

            var fakeRepositoryMock = new Mock<IAuthorRepository>();
            fakeRepositoryMock.Setup(x => x.Find(It.IsAny<Guid>())).Returns(author);


            var service = new AuthorService(fakeRepositoryMock.Object);

            var result =  service.GetAuthor(default(Guid));

            
            Assert.Equal("Full Name 1", result.FullName);
            Assert.Equal("Biography 1", result.Biography);

        }
    }
}
