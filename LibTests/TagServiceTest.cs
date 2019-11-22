using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using WebApplication2.Models;
using WebApplication2.Services.Создатьпапку;
using Xunit;

namespace LibTests
{
    public class TagServiceTest
    {
        
            [Fact]
            public void AddTest()
            {
                var fakeRepository = Mock.Of<ITagRepository>();
                var service = new TagService(fakeRepository);
                var language = new Tag()
                {
                    ID = default(Guid),
                    Name = "Name 1",
                    Discription = "Discription 1"
                };
                service.Create(language);
            }
            [Fact]
            public async Task GetAuthorsTest()
            {
                var tag = new List<Tag>
            {
                new Tag()
                {
                    ID = default(Guid),
                    Name = "Name 1",
                    Discription = "Discription 1"
                },
                    new Tag()
                {
                    ID = default(Guid),
                    Name = "Name 2",
                    Discription = "Discription 2"
                }
            };


                var fakeRepositoryMock = new Mock<ITagRepository>();
                fakeRepositoryMock.Setup(x => x.getList()).ReturnsAsync(tag);
                var service = new TagService(fakeRepositoryMock.Object);

                var result = await service.GetList();

                Assert.Collection(result, tag =>
                {
                    Assert.Equal("Name 1", tag.Name);
                    Assert.Equal("Discription 1", tag.Discription);
                },
                tag =>
                {
                    Assert.Equal("Name 2", tag.Name);
                    Assert.Equal("Discription 2", tag.Discription);
                });
            }

            [Fact]
            public void SearchTest()
            {
                var tag = new Tag
                {
                    ID = default(Guid),
                    Name = "Name 1",
                    Discription = "Discription 1"
                };

                var fakeRepositoryMock = new Mock<ITagRepository>();
                fakeRepositoryMock.Setup(x => x.Find(It.IsAny<Guid>())).Returns(tag);


                var service = new TagService(fakeRepositoryMock.Object);

                var result = service.Get(default(Guid));

                Assert.Equal("Name 1", tag.Name);
                Assert.Equal("Discription 1", tag.Discription);

            
        }
    }
}
