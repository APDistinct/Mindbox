namespace MindboxLib.Test
{
    public class FigureTests
    {
        [Fact]
        public void Circle_GetArea_OK()
        {
            var circle = new Circle(4);
            double expectedArea = Math.PI * 16;
            Assert.Equal(expectedArea, circle.GetArea(), precision: 8);
        }

        [Fact]
        public void Triangle_GetArea_OK()
        {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.Equal(expectedArea, triangle.GetArea(), precision: 8);
        }

        [Fact]
        public void Triangle_IsRightTriangle_OK()
        {
            var triangle = new Triangle(11, 60, 61);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void Triangle_IsRightTriangle_NO()
        {
            var triangle = new Triangle(5, 5, 5);
            Assert.False(triangle.IsRightTriangle());
        }

        [Fact]
        public void Triangle_ThrowsArgumentException_1()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 3, 5));
        }

        [Fact]
        public void Triangle_ThrowsArgumentException_2()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 3, 5));
        }

        [Fact]
        public void Circle_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}
