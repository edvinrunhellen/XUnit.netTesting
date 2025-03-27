using Xunit;
namespace CardGame;


public class UnitTest
{
    [Fact]
    public void TestIsPairPositive()
    {
        // Arrange
        var pairCards = new List<Card>
            {
                new Card('♥', '2'),
                new Card('♦', '2'),
                new Card('♣', '3'),
                new Card('♠', '4'),
                new Card('♥', '5'),

            };
        var hand = new Hand(pairCards);

        // Act
        var result = CompareHands.IsPair(hand);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(hand, result);
    }
    [Fact]
    public void TestIsPairNegative()
    {
        var noPairCards = new List<Card>
        {
            new Card('♥', '6'),
            new Card('♦', '2'),
            new Card('♣', '3'),
            new Card('♠', '4'),
            new Card('♥', '7'),
        };
        var hand = new Hand(noPairCards);

        var result = CompareHands.IsPair(hand);

        Assert.Null(result);
    }
    [Fact]
    public void TestIsTwoPairPositive()
    {
        //Arrange
        var twoPairCards = new List<Card>
        {
            new Card('♥', '2'),
            new Card('♦', '2'),
            new Card('♣', '3'),
            new Card('♠', '3'),
            new Card('♥', '5'),
        };
        var hand = new Hand(twoPairCards);
        //Act
        var result = CompareHands.IsTwoPair(hand);
        //Assert
        Assert.NotNull(result);
        Assert.Equal(hand, result);
    }
    [Fact]
    public void TestIsTwoPairNegative()
    {
        //Arrange
        var noTwoPairCards = new List<Card>
        {
            new Card('♥', '2'),
            new Card('♦', '2'),
            new Card('♣', '3'),
            new Card('♠', '4'),
            new Card('♥', '5'),
        };
        var hand = new Hand(noTwoPairCards);
        //Act
        var result = CompareHands.IsTwoPair(hand);
        //Assert
        Assert.Null(result);
    }
    [Fact]
    public void TestIsThreeOfAKindPositive()
    {
        //Arrange
        var IsThreeOfAKindCards = new List<Card>
        {
            new Card('♥', '2'),
            new Card('♦', '2'),
            new Card('♣', '2'),
            new Card('♠', '4'),
            new Card('♥', '5'),
        };
        var hand = new Hand(IsThreeOfAKindCards);
        //Act
        var result = CompareHands.IsThreeOfAKind(hand);
        //Assert
        Assert.NotNull(result);
        Assert.Equal(hand, result);
    }
    [Fact]
    public void TestIsThreeOfAKindNegative()
    {
        //Arrange
        var noThreeOfAKindCards = new List<Card>
        {
            new Card('♥', '2'),
            new Card('♦', '2'),
            new Card('♣', '3'),
            new Card('♠', '4'),
            new Card('♥', '5'),
        };
        var hand = new Hand(noThreeOfAKindCards);
        //Act
        var result = CompareHands.IsThreeOfAKind(hand);
        //Assert
        Assert.Null(result);
    }
    [Fact]
    public void TestIsStraightPositive()
    {
        //Arrange
        var StraightCards = new List<Card>
        {
            new Card('♥', '2'),
            new Card('♦', '3'),
            new Card('♣', '4'),
            new Card('♠', '5'),
            new Card('♥', '6'),
        };
        var hand = new Hand(StraightCards);
        //Act
        var result = CompareHands.IsStraight(hand);
        //Assert
        Assert.NotNull(result);
        Assert.Equal(hand, result);
    }
    [Fact]
    public void TestIsStraightNegative()
    {
        //Arrange
        var noStraightCards = new List<Card>
        {
            new Card('♥', '2'),
            new Card('♦', '3'),
            new Card('♣', '4'),
            new Card('♠', '5'),
            new Card('♥', '7'),
        };
        var hand = new Hand(noStraightCards);
        //Act
        var result = CompareHands.IsStraight(hand);
        //Assert
        Assert.Null(result);
    }
    [Fact]
    public void TestIsFlushPositive()
    {
        //Arrange
        var IsFlushCards = new List<Card>
        {
            new Card ('♥', '2'),
            new Card ('♥', '3'),
            new Card ('♥', '4'),
            new Card ('♥', '5'),
            new Card ('♥', '6'),
        };
        var hand = new Hand(IsFlushCards);
        //Act
        var result = CompareHands.IsFlush(hand);
        //Assert
        Assert.NotNull(result);
        Assert.Equal(hand, result);
    }
    [Fact]
    public void TestIsFlushNegative()
    {
        //Arrange
        var IsNotFlushCards = new List<Card>
        {
            new Card ('♥', '2'),
            new Card ('♦', '3'),
            new Card ('♥', '4'),
            new Card ('♥', '5'),
            new Card ('♥', '6'),
        };
        var hand = new Hand(IsNotFlushCards);
        //Act
        var result = CompareHands.IsFlush(hand);
        //Assert
        Assert.Null(result);
    }
    [Fact]
    public void TestIsFullHousePositive()
    {
        var isFullHouseCards = new List<Card>
        {
            new Card('♥', '2'),
            new Card('♦', '2'),
            new Card('♣', '2'),
            new Card('♠', '3'),
            new Card('♥', '3'),
        };
        var hand = new Hand(isFullHouseCards);
        //Act
        var result = CompareHands.IsFullHouse(hand);
        //Assert
        Assert.NotNull(result);
        Assert.Equal(hand, result);
    }
    [Fact]
    public void TestIsFullHouseNegative()
    {
        var isNotFullHouseCards = new List<Card>
        {
            new Card('♥', '2'),
            new Card('♦', '2'),
            new Card('♣', '3'),
            new Card('♠', '3'),
            new Card('♥', '4'),
        };
        var hand = new Hand(isNotFullHouseCards);
        //Act 
        var result = CompareHands.IsFullHouse(hand);
        //Assert
        Assert.Null(result);
    }
    [Fact]
    public void TestIsFourOfAKind()
    {
        //Arrange
        var IsFourOfAKindCards = new List<Card>
        {
            new Card('♥', '2'),
            new Card('♦', '2'),
            new Card('♣', '2'),
            new Card('♠', '2'),
            new Card('♥', '3'),
        };
        var hand = new Hand(IsFourOfAKindCards);
        //Act
        var result = CompareHands.IsFourOfAKind(hand);
        //Assert
        Assert.NotNull(result);
        Assert.Equal(hand, result);
    }
    [Fact]
    public void TestIsFourOfAKindNegative()
    {
        //Arrange
        var IsNotFourOfAKindCards = new List<Card>
        {
            new Card('♥', '2'),
            new Card('♦', '2'),
            new Card('♣', '2'),
            new Card('♠', '3'),
            new Card('♥', '3'),
        };
        var hand = new Hand(IsNotFourOfAKindCards);
        //Act
        var result = CompareHands.IsFourOfAKind(hand);
        //Assert
        Assert.Null(result);
    }
    [Fact]
    public void TestIsStraightFlushPositive()
    {
        var IsStraightFlushPositive = new List<Card>
        {
            new Card('♥', '2'),
            new Card('♥', '3'),
            new Card('♥', '4'),
            new Card('♥', '5'),
            new Card('♥', '6'),
        };
        var hand = new Hand(IsStraightFlushPositive);
        //Act
        var result = CompareHands.IsStraightFlush(hand);
        //Assert
        Assert.NotNull(result);
        Assert.Equal(hand, result);
    }
    [Fact]
    public void TestIsStraightFlushNegative()
    {
        //Arrange
        var IsNotStraightFlushCards = new List<Card>
        {
            new Card('♥', '2'),
            new Card('♥', '3'),
            new Card('♥', '4'),
            new Card('♥', '5'),
            new Card('♥', '7'),
        };
        var hand = new Hand(IsNotStraightFlushCards);
        //Act
        var result = CompareHands.IsStraightFlush(hand);
        //Assert
        Assert.Null(result);
    }
    [Fact]
    public void TestIsRoyalFlushPositive()
    {
        //Arrange
        var IsRoyalFlushCards = new List<Card>
        {
            new Card('♥', 'T'),
            new Card('♥', 'J'),
            new Card('♥', 'Q'),
            new Card('♥', 'K'),
            new Card('♥', 'A'),
        };
        var hand = new Hand(IsRoyalFlushCards);
        //Act
        var result = CompareHands.IsRoyalFlush(hand);
        //Assert
        Assert.NotNull(result);
        Assert.Equal(hand, result);
    }
    [Fact]
    public void TestIsRoyalFlushNegative()
    {
        var isNotRoyalFlushCards = new List<Card>
        {
            new Card('♥', 'T'),
            new Card('♥', 'J'),
            new Card('♥', 'Q'),
            new Card('♥', 'K'),
            new Card('♥', '2'),
        };
        var hand = new Hand(isNotRoyalFlushCards);
        //Act
        var result = CompareHands.IsRoyalFlush(hand);
        //Assert
        Assert.Null(result);
    }
    [Fact]
    public void TestIsRoyalStraightFlushPositive()
    {
        //Arrange
        var isRoyalStraightFlushCards = new List<Card>
        {
            new Card('♥', 'T'),
            new Card('♥', 'J'),
            new Card('♥', 'Q'),
            new Card('♥', 'K'),
            new Card('♥', 'A'),
        };
        var hand = new Hand(isRoyalStraightFlushCards);
        //Act
        var result = CompareHands.IsRoyalStraightFlush(hand);
        //Assert
        Assert.NotNull(result);
        Assert.Equal(hand, result);
    }
    [Fact]
    public void TestIsRoyalStraightFlushNegative()
    {
        //Arrange
        var isNotRoaylStraightFlushCards = new List<Card>
        {
            new Card('♥', 'T'),
            new Card('♥', 'J'),
            new Card('♥', 'Q'),
            new Card('♥', 'K'),
            new Card('♥', '2'),
        };
        var hand = new Hand(isNotRoaylStraightFlushCards);
        //Act
        var result = CompareHands.IsRoyalStraightFlush(hand);
        //Assert
        Assert.Null(result);
    }
}




