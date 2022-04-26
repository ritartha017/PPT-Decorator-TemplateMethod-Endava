using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using FluentAssertions;

namespace GildedRoseTests;

public class GildedRoseTest
{
    private const string ItemName = "MyAwesomeItemName";

    [Fact]
    public void SellInDateDecreases_ButQualityCannotBeNegative()
    {
        var item = new List<Item> { new ItemBuilder()
            .WithName(ItemName)
            .WithSellIn(0)
            .WithQuality(0)
            .Build()
        };
        var app = new GildedRose(item);
        var expected = new ItemBuilder()
            .WithName(ItemName)
            .WithSellIn(-1)
            .WithQuality(0)
            .Build();

        app.UpdateQuality();

        app.GetItems()[0].Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void QualityDecreases()
    {
        var item = new List<Item> { new ItemBuilder()
            .WithName(ItemName)
            .WithSellIn(10)
            .WithQuality(10)
            .Build()
        };
        var app = new GildedRose(item);
        var expected = new ItemBuilder()
            .WithName(ItemName)
            .WithSellIn(9)
            .WithQuality(9)
            .Build();

        app.UpdateQuality();

        app.GetItems()[0].Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void QualityDecreases_ButTwiceFasterAfterSellInDateExpired()
    {
        var item = new List<Item> { new ItemBuilder()
            .WithName(ItemName)
            .WithSellIn(0)
            .WithQuality(10)
            .Build()
        };
        var app = new GildedRose(item);
        var expected = new ItemBuilder()
            .WithName(ItemName)
            .WithSellIn(-1)
            .WithQuality(8)
            .Build();

        app.UpdateQuality();

        app.GetItems()[0].Should().BeEquivalentTo(expected);
    }
}

