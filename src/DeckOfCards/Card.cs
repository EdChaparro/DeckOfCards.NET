using System;

namespace IntrepidProducts.DeckOfCards
{
    public enum Rank
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public enum Suit
    {
        Spades = 1,
        Clubs = 2,
        Hearts = 3,
        Diamonds =4
    }

    public class Card
    {
        public Card(Rank rank, Suit suit)
        {
            CardRank = rank;
            CardSuit = suit;
        }

        public Rank CardRank { get; } 
        public Suit CardSuit { get; }

        public bool IsAce => CardRank == Rank.Ace;

        public bool IsRoyalty =>
            CardRank == Rank.Jack ||
            CardRank == Rank.Queen ||
            CardRank == Rank.King;

        public bool IsNumber => !IsAce && !IsRoyalty;

        #region Equality
        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(Card))
            {
                return base.Equals(obj);
            }

            return Equals(obj as Card);
        }

        protected bool Equals(Card other)
        {
            return CardRank == other.CardRank && CardSuit == other.CardSuit;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine((int) CardRank, (int) CardSuit);
        }
        #endregion

        public override string ToString()
        {
            return $"{CardRank} of {CardSuit}";
        }
    }
}