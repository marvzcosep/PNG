# Play'n GO - Poker Game
Poker is a game of chance.

#### Assumptions:

Suits
- H - Hearts
- S - Spades
- C - Clubs
- D - Diamonds

Rank (Lowest to Highest)
- 0 - Two
- 1 - Three
- 2 - Four
- 3 - Five
- 4 - Six
- 5 - Seven
- 6 - Eight
- 7 - Nine
- 8 - Ten
- 9 - Jack
- 10 - Queen
- 11 - King
- 12 - Ace

Hand Categories (Highest to Lowest)
- Royal Flush - a hand consisting of the cards A, K, Q, J, 10, of the same suit. This is the rarest and strongest hand in poker.
```
Sample:
var cards = new Cards
            {
                new Card(Rank.Ace, Suit.Clubs),
                new Card(Rank.King, Suit.Clubs),
                new Card(Rank.Queen, Suit.Clubs),
                new Card(Rank.Jack, Suit.Clubs),
                new Card(Rank.Ten, Suit.Clubs)
            };
```
- Straight Flush - A straight flush is the best natural hand. A straight flush is a straight (5 cards in order, such as 5-6-7-8-9) that are all of the same suit. As in a regular straight, you can have an ace either high (A-K-Q-J-T) or low (5-4-3-2-1). However, a straight may not 'wraparound'. (Such as K-A-2-3-4, which is not a straight). An Ace high straight-flush is called a Royal Flush and is the highest natural hand.
```
Sample:
var cards = new Cards
            {
                new Card(Rank.Seven, Suit.Spades),
                new Card(Rank.Four, Suit.Spades),
                new Card(Rank.Five, Suit.Spades),
                new Card(Rank.Six, Suit.Spades),
                new Card(Rank.Three, Suit.Spades)
            };
```
- Four Of A Kind - Four of a kind is simply four cards of the same rank. If there are two or more hands that qualify, the hand with the higher-rank four of a kind wins. If, in some bizarre game with many wild cards, there are two four of a kinds with the same rank, then the one with the high card outside the four of the kind wins. General Rule: When hands tie on the rank of a pair, three of a kind, etc, the cards outside break ties following the High Card rules.
```
Sample:
var cards = new Cards
            {
                new Card(Rank.Seven, Suit.Clubs),
                new Card(Rank.Four, Suit.Spades),
                new Card(Rank.Four, Suit.Diamonds),
                new Card(Rank.Four, Suit.Clubs),
                new Card(Rank.Four, Suit.Hearts)
            };
```
- Full House - A full house is a three of a kind and a pair, such as K-K-K-5-5. Ties are broken first by the three of a kind, then pair. So K-K-K-2-2 beats Q-Q-Q-A-A, which beats Q-Q-Q-J-J. (Obviously, the three of a kind can only be similiar if wild cards are used.)
```
Sample:
var cards = new Cards
            {
                new Card(Rank.Two, Suit.Clubs),
                new Card(Rank.Four, Suit.Spades),
                new Card(Rank.Two, Suit.Diamonds),
                new Card(Rank.Four, Suit.Hearts),
                new Card(Rank.Four, Suit.Clubs)
            };
```
- Flush - A flush is a hand where all of the cards are the same suit, such as J-8-5-3-2, all of spades. When flushes ties, follow the rules for High Card.
```
Sample:
var cards = new Cards
            {
                new Card(Rank.Seven, Suit.Clubs),
                new Card(Rank.King, Suit.Clubs),
                new Card(Rank.Eight, Suit.Clubs),
                new Card(Rank.Two, Suit.Clubs),
                new Card(Rank.Ten, Suit.Clubs)
            };
```
- Straight - A straight is 5 cards in order, such as 4-5-6-7-8. An ace may either be high (A-K-Q-J-T) or low (5-4-3-2-1). However, a straight may not 'wraparound'. (Such as Q-K-A-2-3, which is not a straight). When straights tie, the highest straight wins. (AKQJT beats KQJT9 down to 5432A). If two straights have the same value (AKQJT vs AKQJT) they split the pot.
```
Sample:
var cards = new Cards
            {
                new Card(Rank.Nine, Suit.Clubs),
                new Card(Rank.Seven, Suit.Spades),
                new Card(Rank.Ten, Suit.Diamonds),
                new Card(Rank.Eight, Suit.Clubs),
                new Card(Rank.Six, Suit.Hearts)
            };
```
- Three Of a Kind - Three cards of any rank, matched with two cards that are not a pair (otherwise it would be a Full House . Again, highest three of a kind wins. If both are the same rank, then the compare High Cards.
```
Sample:
var cards = new Cards
            {
                new Card(Rank.Eight, Suit.Clubs),
                new Card(Rank.King, Suit.Spades),
                new Card(Rank.Eight, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clubs),
                new Card(Rank.Eight, Suit.Hearts)
            };
```
- Two Pair - This is two distinct pairs of card and a 5th card. The highest pair wins ties. If both hands have the same high pair, the second pair wins. If both hands have the same pairs, the high card wins.
```
Sample:
var cards = new Cards
            {
                new Card(Rank.Six, Suit.Clubs),
                new Card(Rank.Nine, Suit.Spades),
                new Card(Rank.Ace, Suit.Diamonds),
                new Card(Rank.Nine, Suit.Clubs),
                new Card(Rank.Ace, Suit.Hearts)
            };
```
- One Pair - One pair with three distinct cards. High card breaks ties.
```
Sample:
var cards = new Cards
            {
                new Card(Rank.Six, Suit.Clubs),
                new Card(Rank.Nine, Suit.Spades),
                new Card(Rank.King, Suit.Diamonds),
                new Card(Rank.Nine, Suit.Clubs),
                new Card(Rank.Ace, Suit.Hearts)
            };
```
- High Card - This is any hand which doesn't qualify as any one of the above hands. If nobody has a pair or better, then the highest card wins. If multiple people tie for the highest card, they look at the second highest, then the third highest etc. High card is also used to break ties when the high hands both have the same type of hand (pair, flush, straight, etc).
```
Sample:
var cards = new Cards
            {
                new Card(Rank.Two, Suit.Clubs),
                new Card(Rank.King, Suit.Spades),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clubs),
                new Card(Rank.Ace, Suit.Hearts)
            };
```

#### Additional Note:
- There are no wildcards
- Didn't include bets
- Two being the lowers and Ace being the Highest
- If both players have identical hand with different suit, both players
win.
- If both players have identical hand with different rank, it should be evaluated based on the outside cards to determine the winner(s).
#### References:
- https://www.contrib.andrew.cmu.edu/~gc00/reviews/pokerrules