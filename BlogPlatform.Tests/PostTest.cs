using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BlogPlatform.Tests
{
    public class PostTest
    {
        Post sut;

        public PostTest()
        {

        }

        [Fact]
        public void Content_Contructor_Sets_Title_On_Content()
        {
            // Arrange

            // Act
            //sut = new Post(1, "BoB", "", "", 0);

            // Assert
            // Assert.Equal(1,"BoB", sut.Title);

        }
        [Fact]
        public void Content_Constuctor_Sets_Body_of_Content()
        {
            // Arrange

            // Act
            //sut = new Post(1, "", "Body", "", 0);

            // Assert
            //Assert.Equal("Body", sut.Body);
        }

        [Fact]
        public void Content_Constuctor_Sets_Author_of_Content()
        {
            // Arrange

            // Act
            //sut = new Post(1, "", "", "Me", 0);

            // Assert
            //Assert.Equal("Me", sut.Author);
        }
        [Fact]
        public void Content_Constuctor_Sets_Publish_Date_of_Content()
        {
            // Arrange

            // Act
            //sut = new Post(1, "", "", "", 1972);

            // Assert
            //Assert.Equal(1972, sut.PublishDate);

        }
        [Fact]
        public void Content_Constuctor_Sets_Category_of_Content()
        {
            // Arrange

            // Act
            //sut = new Post(1,"", "", "", 0 );

            // Assert
            //Assert.Equal("Flag", sut.Category);

        }


    }

    
}
