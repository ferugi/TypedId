using System.Threading.Tasks;
using TypedId;
using TypedId.Examples;
using Xunit;

namespace TypedIdTests
{
    public class IdForTests
    {
        [Fact]
        public async Task IdForT_WithEmptyString_ReturnsNewId()
        {
            // Arrange
            var idInput = string.Empty;

            // Act
            var id = IdFor<Person>.Wrap(idInput);

            // Assert
            Assert.NotNull(id);
        }
    }
}
