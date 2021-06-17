using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BlogPlatform.Tests
{
    public class ContentTest
    {
        Content sut;

        public ContentTest()
        {

        }

        [Fact]
        public void Content_Contructor_Sets_Title_On_Content()
        {
            // Arrange

            // Act
            sut = new Content("BoB", "", "", 0,"");

            // Assert
            Assert.Equal("BoB", sut.Title);

        }

        public void Content_Constuctor_Sets_Body_of_Content()
        {
            // Arrange

            // Act
            sut = new Content("", "Body", "", 0, "");

            // Assert
            Assert.Equal("Body", sut.Body);
        }

        public void Content_Constuctor_Sets_Author_of_Content()
        {
            // Arrange

            // Act
            sut = new Content("", "", "Me", 0, "");

            // Assert
            Assert.Equal("Me", sut.Author);
        }

        public void Content_Constuctor_Sets_Publish_Date_of_Content()
        {
            // Arrange

            // Act
            sut = new Content("", "", "", 1972, "");

            // Assert
            Assert.Equal(1972, sut.PublishDate);

        }

        public void Content_Constuctor_Sets_Category_of_Content()
        {
            // Arrange

            // Act
            sut = new Content("", "", "", 0, "Flag");

            // Assert
            Assert.Equal("Flag", sut.Category);

        }


    }

    
}
