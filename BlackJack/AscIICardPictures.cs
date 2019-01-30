using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class AscIICardPictures
    {
        public static void findAscIIPicture(List<Card> deck, int cardNumber)
        {
            if (deck[cardNumber].Suit == "Club")
            {
                if (deck[cardNumber].NameAlphabetic == NameEnum.ace)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|A _  |\n| ( ) |\n|(_'_)|\n|  |  |\n|____V|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.two)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|2    |\n|  &  |\n|     |\n|  &  |\n|____Z| ");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.three)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|3    |\n| & & |\n|     |\n|  &  |\n|____E|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.four)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|4    |\n| & & |\n|     |\n| & & |\n|____h|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.five)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|5    |\n| & & |\n|  &  |\n| & & |\n|____S|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.six)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|6    |\n| & & |\n| & & |\n| & & |\n|____9|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.seven)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|7    |\n| & & |\n| &&& |\n| & & |\n|____L|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.eight)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|8    |\n| &&& |\n| & & |\n| &&& |\n|____8|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.nine)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|9    |\n| &&& |\n| &&& |\n| &&& |\n|____6|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.ten)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|10 & |\n| &&& |\n| &&& |\n| &&& |\n|___0I|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.jack)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|J  ww|\n| o {)|\n| |%%%|\n| | % |\n|__%%[|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.queen)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|Q  ww|\n| o {(|\n|o o%%|\n| |%%%|\n|_%%%O|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.king)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|K  WW|\n| o {)|\n|o o%%|\n| |%%%|\n|_%%%>|");
                }
                else
                {
                    throw new ArgumentException("Card Name Not Found");
                }
            }
            else if (deck[cardNumber].Suit == "Diamond")
            {
                if (deck[cardNumber].NameAlphabetic == NameEnum.ace)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|A ^  |\n| / \\ |\n| \\ / |\n|  .  |\n|____V|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.two)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|2    |\n|  o  |\n|     |\n|  o  |\n|____Z|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.three)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|3    |\n| o o |\n|     |\n|  o  |\n|____E|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.four)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|4    |\n| o o |\n|     |\n| o o |\n|____h|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.five)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|5    |\n| o o |\n|  o  |\n| o o |\n|____S|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.six)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|6    |\n| o o |\n| o o |\n| o o |\n|____9|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.seven)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|7    |\n| o o |\n|o o o|\n| o o |\n|____L|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.eight)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|8    |\n|o o o|\n| o o |\n|o o o|\n|____8|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.nine)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|9    |\n|o o o|\n|o o o|\n|o o o|\n|____6|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.ten)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|10 o |\n|o o o|\n|o o o|\n|o o o|\n|___0I|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.jack)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|J  ww|\n| /\\{)|\n| \\/% |\n|   % |\n|__%%[|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.queen)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|Q  ww|\n| /\\{(|\n| \\/%%|\n|  %%%|\n|_%%%O|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.king)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|K  WW|\n| /\\{)|\n| \\/%%|\n|  %%%|\n|_%%%>|");
                }
                else
                {
                    throw new ArgumentException("Card Name Not Found");
                }
            }
            else if (deck[cardNumber].Suit == "Heart")
            {
                if (deck[cardNumber].NameAlphabetic == NameEnum.ace)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|A_ _ |\n|( v )|\n| \\ / |\n|  .  |\n|____V|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.two)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|2    |\n|  v  |\n|     |\n|  v  |\n|____Z|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.three)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|3    |\n| v v |\n|     |\n|  v  |\n|____E|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.four)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|4    |\n| v v |\n|     |\n| v v |\n|____h|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.five)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|5    |\n| v v |\n|  v  |\n| v v |\n|____S|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.six)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|6    |\n| v v |\n| v v |\n| v v |\n|____9|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.seven)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|7    |\n| v v |\n|v v v|\n| v v |\n|____L|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.eight)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|8    |\n|v v v|\n| v v |\n|v v v|\n|____8|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.nine)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|9    |\n|v v v|\n|v v v|\n|v v v|\n|____6|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.ten)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|10 v |\n|v v v|\n|v v v|\n|v v v|\n|___0I|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.jack)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|J  ww|\n|   {)|\n|(v) %|\n|  v%%|\n|__%%[|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.queen)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|Q  ww|\n|   {(|\n|(v)%%|\n| v%%%|\n|_%%%O|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.king)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|K  WW|\n|   {)|\n|(v)%%|\n| v%%%|\n|_%%%>|");
                }
                else
                {
                    throw new ArgumentException("Card Name Not Found");
                }
            }
            else if (deck[cardNumber].Suit == "Spade")
            {
                if (deck[cardNumber].NameAlphabetic == NameEnum.ace)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|A .  |\n| /.\\ |\n|(_._)|\n|  |  |\n|____V|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.two)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|2    |\n|  ^  |\n|     |\n|  ^  |\n|____Z|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.three)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|3    |\n| ^ ^ |\n|     |\n|  ^  |\n|____E|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.four)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|4    |\n| ^ ^ |\n|     |\n| ^ ^ |\n|____h|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.five)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|5    |\n| ^ ^ |\n|  ^  |\n| ^ ^ |\n|____S|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.six)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|6    |\n| ^ ^ |\n| ^ ^ |\n| ^ ^ |\n|____9|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.seven)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|7    |\n| ^ ^ |\n|^ ^ ^|\n| ^ ^ |\n|____L|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.eight)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|8    |\n|^ ^ ^|\n| ^ ^ |\n|^ ^ ^|\n|____8|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.nine)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|9    |\n|^ ^ ^|\n|^ ^ ^|\n|^ ^ ^|\n|____6|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.ten)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|10 ^ |\n|^ ^ ^|\n|^ ^ ^|\n|^ ^ ^|\n|___0I|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.jack)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|J  ww|\n| ^ {)|\n|(.)% |\n| | % |\n|__%%[|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.queen)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|Q  ww|\n| ^ {(|\n|(.)%%|\n| |%%%|\n|_%%%O|");
                }
                else if (deck[cardNumber].NameAlphabetic == NameEnum.king)
                {
                    deck[cardNumber].AscIIPicture = (" _____\n|K  WW|\n| ^ {)|\n|(.)%%|\n| |%%%|\n|_%%%>|");
                }
                else
                {
                    throw new ArgumentException("Card Name Not Found");
                }
            }
            else
            {
                throw new ArgumentException("Card Suit Not Found");
            }
        }
    }
}
