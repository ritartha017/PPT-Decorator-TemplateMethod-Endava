using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using FluentAssertions;

namespace GildedRoseTests;

public class ConjuredTest
{
    private const string Conjured = "Conjured Mana Cake";

    [Fact]
    public void Conjured_DecreasesInQuality_TwiceTheSpeed()
    {
        var item = new List<Item> { new ItemBuilder()
            .WithName(Conjured)
            .WithSellIn(3)
            .WithQuality(6)
            .Build()
        };
        var app = new GildedRose(item);
        var expected = new ItemBuilder()
            .WithName(Conjured)
            .WithSellIn(2)
            .WithQuality(4)
            .Build();

        app.UpdateQuality();

        app.GetItems()[0].Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Conjured_DecreasesInQuality_TwiceTheSpeed_AlsoWhenSellInExpired()
    {
        var item = new List<Item> { new ItemBuilder()
            .WithName(Conjured)
            .WithSellIn(0)
            .WithQuality(6)
            .Build()
        };
        var app = new GildedRose(item);
        var expected = new ItemBuilder()
            .WithName(Conjured)
            .WithSellIn(-1)
            .WithQuality(2)
            .Build();

        app.UpdateQuality();

        app.GetItems()[0].Should().BeEquivalentTo(expected);
    }
}
