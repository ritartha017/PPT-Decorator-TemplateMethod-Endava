using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using FluentAssertions;

namespace GildedRoseTests;

public class AgedBrieTest
{
    private const string AgedBrie = "Aged Brie";

    [Fact]
    public void AgedBrie_IncreasesInQuality()
    {
        var item = new List<Item> { new ItemBuilder()
            .WithName(AgedBrie)
            .WithSellIn(2)
            .WithQuality(2)
            .Build() 
        };
        var app = new GildedRose(item);
        var expected = new ItemBuilder()
            .WithName(AgedBrie)
            .WithSellIn(1)
            .WithQuality(3)
            .Build();

        app.UpdateQuality();

        app.GetItems()[0].Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void AgedBrie_CannotGoOver50Quality()
    {
        var item = new List<Item> { new ItemBuilder()
            .WithName(AgedBrie)
            .WithSellIn(2)
            .WithQuality(50)
            .Build() 
        };
        var app = new GildedRose(item);
        var expected = new ItemBuilder()
            .WithName(AgedBrie)
            .WithSellIn(1)
            .WithQuality(50)
            .Build();

        app.UpdateQuality();

        app.GetItems()[0].Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void AgedBrie_IncreasesInQuality_ByOneOutside10Days()
    {
        var item = new List<Item> { new ItemBuilder()
            .WithName(AgedBrie)
            .WithSellIn(20)
            .WithQuality(2)
            .Build()
        };
        var app = new GildedRose(item);
        var expected = new ItemBuilder()
            .WithName(AgedBrie)
            .WithSellIn(19)
            .WithQuality(3)
            .Build();

        app.UpdateQuality();

        app.GetItems()[0].Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void AgedBrie_IncreasesInQuality_DoublesWhenOff()
    {
        var item = new List<Item> { new ItemBuilder()
            .WithName(AgedBrie)
            .WithSellIn(0)
            .WithQuality(2)
            .Build()
        };
        var app = new GildedRose(item);
        var expected = new ItemBuilder()
            .WithName(AgedBrie)
            .WithSellIn(-1)
            .WithQuality(4)
            .Build();

        app.UpdateQuality();

        app.GetItems()[0].Should().BeEquivalentTo(expected);
    }
}
