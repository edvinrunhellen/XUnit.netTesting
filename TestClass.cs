using Xunit;
namespace CardGame;


public class UnitTest
{
    // Tests for different hands - Pair, Two Pair, Three of a Kind, Straight, Flush, Full House, Four of a Kind, Straight Flush, Royal Flush, Royal Straight Flush
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
        Assert.Equal(hand, result.hand);

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

        Assert.Null(result.hand);
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
        Assert.Equal(hand, result.hand);
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
        Assert.Null(result.hand);
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
        Assert.Equal(hand, result.hand);
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
        Assert.Null(result.hand);
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
        Assert.Equal(hand, result.hand);
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
        Assert.Null(result.hand);
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
        Assert.Equal(hand, result.hand);
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
        Assert.Null(result.hand);
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
        Assert.Equal(hand, result.hand);
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
        Assert.Null(result.hand);
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
        Assert.Equal(hand, result.hand);
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
        Assert.Null(result.hand);
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
        Assert.Equal(hand, result.hand);
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
        Assert.Null(result.hand);
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
        Assert.Equal(hand, result.hand);
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
        Assert.Null(result.hand);
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
        Assert.Equal(hand, result.hand);
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
        Assert.Null(result.hand);
    }
    //Test with Theory - Pair 
    [Theory]
    [InlineData(new char[] { '♥', '2', '♦', '2', '♣', '3', '♠', '4', '♥', '5' }, true)] //Pair
    [InlineData(new char[] { '♠', 'A', '♦', 'K', '♣', 'Q', '♥', 'J', '♠', '9' }, false)] //No Pair

    public void TestIsPairTheoryUse(char[] cardData, bool expectedResult)
    {
        var pairCards = new List<Card>
        {
        new Card(cardData[0], cardData[1]),
        new Card(cardData[2], cardData[3]),
        new Card(cardData[4], cardData[5]),
        new Card(cardData[6], cardData[7]),
        new Card(cardData[8], cardData[9])
        };
        var hand = new Hand(pairCards);

        //Act
        var (resultHand, _) = CompareHands.IsPair(hand);
        var result = resultHand != null;

        //Assert
        Assert.Equal(expectedResult, result);

    }

    //Test for hand 1 wins
    [Fact]
    public void TestCompareHandsHand1Wins()
    {
        // Arrange
        var hand1 = new List<Card>
    {
        new Card('♥', '2'),
        new Card('♦', '2'),
        new Card('♣', '3'),
        new Card('♠', '4'),
        new Card('♥', '5'),
    };

        var hand2 = new List<Card>
    {
        new Card('♥', '6'),
        new Card('♦', '2'),
        new Card('♣', '7'),
        new Card('♠', '8'),
        new Card('♥', '9'),
    };

        // Act
        var result = CompareHands.CheckHands(new Hand(hand1), new Hand(hand2));

        // Assert
        Assert.Equal(result.winningHand.Cards, hand1);
    }
    //Test for hand 2 wins
    [Fact]
    public void TestCompareHandsHand2Wins()
    {
        // Arrange
        var hand1 = new List<Card>
    {
        new Card('♥', '8'),
        new Card('♦', '2'),
        new Card('♣', '3'),
        new Card('♠', '4'),
        new Card('♥', '5'),
    };

        var hand2 = new List<Card>
    {
        new Card('♥', '3'),
        new Card('♦', '3'),
        new Card('♣', '7'),
        new Card('♠', '8'),
        new Card('♥', '9'),
    };

        // Act
        var result = CompareHands.CheckHands(new Hand(hand1), new Hand(hand2));

        // Assert
        Assert.Equal(result.winningHand.Cards, hand2);
    }

    //Test for draw - Exactly the same hand
    [Fact]
    public void TestIfDraw()
    {
        // Arrange
        var hand1 = new List<Card>
    {
        new Card('♥', '8'),
        new Card('♦', '2'),
        new Card('♣', '3'),
        new Card('♠', '4'),
        new Card('♥', '5'),
    };

        var hand2 = new List<Card>
    {
        new Card('♥', '8'),
        new Card('♦', '2'),
        new Card('♣', '3'),
        new Card('♠', '4'),
        new Card('♥', '5'),
    };

        // Act
        var result = CompareHands.CheckHands(new Hand(hand1), new Hand(hand2));

        // Assert
        Assert.Null(result.winningHand);
    }


    //Test for same pair but different highest card
    [Fact]
    public void TestCompareHighestCardWhereBothHavePair()
    {
        // Arrange
        var hand1 = new List<Card>
    {
        new Card('♥', '4'),
        new Card('♦', '4'),
        new Card('♣', '9'),
        new Card('♠', '8'),
        new Card('♥', '5'),

    };

        var hand2 = new List<Card>
    {
        new Card('♥', '2'),
        new Card('♦', '2'),
        new Card('♣', '9'),
        new Card('♠', '8'),
        new Card('♥', '5'),
    };

        // Act
        var result = CompareHands.CompareHighestCard(new Hand(hand1), new Hand(hand2));

        // Assert
        Assert.Equal(hand1, result.Cards);
    }
    //Test above. Something is wrong. hand 1 always wins in this test.


    //Test forno pair - compare highest card
    [Fact]
    public void TestCompareHighestCard()
    {
        // Arrange
        var hand1 = new List<Card>
    {
        new Card('♥', '2'),
        new Card('♦', '3'),
        new Card('♣', '9'),
        new Card('♠', '8'),
        new Card('♥', '5'),
    };

        var hand2 = new List<Card>
    {
        new Card('♥', '3'),
        new Card('♦', '4'),
        new Card('♣', '9'),
        new Card('♠', '8'),
        new Card('♥', '6'),
    };

        // Act
        var result = CompareHands.CheckHands(new Hand(hand1), new Hand(hand2));

        // Assert
        Assert.Equal(hand2, result.winningHand.Cards);
    }
}






