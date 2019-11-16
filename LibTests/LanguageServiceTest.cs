using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using WebApplication2.Models;
using WebApplication2.Services.Languages;
using Xunit;

namespace LibTests
{
    public class LanguageServiceTest
    {
        [Fact]
        public void AddTest()
        {
            var fakeRepository = Mock.Of<ILanguageRepository>();
            var service = new LanguageService(fakeRepository);
            var language = new Language()
            {
                ID = default(Guid),
                LanguageName = "Language 1"
            };
            service.Create(language);
        }
        [Fact]
        public async Task GetAuthorsTest()
        {
            var language = new List<Language>
            {
                new Language() {
                ID = default(Guid),
                LanguageName = "Language 1"
                },
                new Language() {
                ID = default(Guid),
                LanguageName = "Language 2"
                }
            };


            var fakeRepositoryMock = new Mock<ILanguageRepository>();
            fakeRepositoryMock.Setup(x => x.getList()).ReturnsAsync(language);
            var service = new LanguageService(fakeRepositoryMock.Object);

            var result = await service.GetList();

            Assert.Collection(result, bookType =>
            {
                Assert.Equal("Language 1", bookType.LanguageName);
            },
            bookType =>
            {
                Assert.Equal("Language 2", bookType.LanguageName);
            });
        }
        [Fact]
        public void SearchTest()
        {
            var language = new Language
            {
                ID = default(Guid),
                LanguageName = "Language 1"
            };

            var fakeRepositoryMock = new Mock<ILanguageRepository>();
            fakeRepositoryMock.Setup(x => x.Find(It.IsAny<Guid>())).Returns(language);


            var service = new LanguageService(fakeRepositoryMock.Object);

            var result = service.Get(default(Guid));

            Assert.Equal("Language 1", result.LanguageName);

        }
    }
}
