using System;
using System.Collections.Generic;
using System.Text;

public static class TrascrizioneRNA
{
    public static string ToRna(string dna)
    {
        string rna = "";
        if( String.IsNullOrEmpty( dna ) )
            return "";
        
        foreach(char b in  dna){

            switch(b){
                case 'C':
                rna = rna + "G";
                break;

                case 'G':
                rna = rna + "C";
                break;

                case 'T':
                rna = rna + "A";
                break;

                case 'A':
                    rna = rna + "U";
                break;
            }
        }
       
        return rna;
        
    }
}