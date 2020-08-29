﻿using System;
using System.Collections.Generic;
using System.Linq;
using intrepidproducts.common;

namespace IntrepidProducts.DeckOfCards
{
    public class StandardDeck
    {
        private IList<Card> _cards = new List<Card>();

        public IList<Card> Cards
        {
            get
            {
                if (_cards.Any())
                {
                    return _cards;
                }

                return _cards = NewDeck();
            }
        }

        public StandardDeck Shuffle()
        {
            var randomGenerator = new Random();

            _cards = _cards.OrderBy(x => randomGenerator.Next()).ToList();
            _cards = _cards.OrderBy(x => randomGenerator.Next()).ToList();
            _cards = _cards.OrderBy(x => randomGenerator.Next()).ToList();

            return this;
        }

        public static IList<Card> NewDeck()
        {
            var ranks = Rank.Ace.GetAllValues().ToList();
            var suits = Suit.Clubs.GetAllValues().ToList();

            var cards = new List<Card>();

            foreach (var rank in ranks)
            {
                foreach (var suit in suits)
                {
                    cards.Add(new Card(rank, suit));
                }
            }

            return cards;
        }
    }
}