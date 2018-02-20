using System;
using System.Text.RegularExpressions;

namespace TDD_Practise
{
    public struct CharChainMatch
    {
        public int startPosition;
        public int length;
        public char letter;

        public CharChainMatch(int startPosition, int length,char letter)
        {
            this.startPosition = startPosition;
            this.length = length;
            this.letter = letter;
        }
    }

    public class String_Easy_Compressor
    {
        public String_Easy_Compressor()
        {
        }

        public string Compress(string text)
        {
            int currentPosition = 0;
            CharChainMatch? currentMatch = null;
            while(currentPosition < text.Length)
            {
                currentMatch = matchSampleCharactersChain(text, currentPosition);
                if(currentMatch.HasValue)
                {
                    text = text.Remove(currentMatch.Value.startPosition, currentMatch.Value.length).Insert(currentMatch.Value.startPosition, currentMatch.Value.letter + currentMatch.Value.length.ToString());
                    currentPosition = currentMatch.Value.startPosition + 2;
                } else
                {
                    break;
                }
            }
            return text;
        }

        public CharChainMatch? matchSampleCharactersChain(string text, int startPosition, int minChainLength = 2)
        {
            CharChainMatch? chainMatch = null;
            int currentPosition = startPosition, startMatchPosition = currentPosition, numberOfMatches = 0;
            char currentLetter = text[currentPosition];

            if (currentPosition >= text.Length)
            {
                return null;
            }

            for(; currentPosition < text.Length; currentPosition++)
            {
                if(Char.IsLetter(text[currentPosition]) && currentLetter == text[currentPosition])
                {
                    numberOfMatches++;

                } else if(numberOfMatches >= minChainLength)
                {
                    chainMatch = new CharChainMatch(startMatchPosition, numberOfMatches, currentLetter);
                    break;

                } else
                {
                    numberOfMatches = 1;
                    startMatchPosition = currentPosition;
                    currentLetter = text[currentPosition];
                }
            }
            return chainMatch;
        }
    }
}