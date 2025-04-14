using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Partie3
{
    public class Batiment
    {
        int CoordoX { get; set; }
        int CoordoY { get; set; } 
        public Statut StatutBatiment { get; set; }
        public int QuantiteRessource {  get; set; }
        public int Priorite {  get; set; }
        
        public Batiment(int coordoX, int coordoY, Statut statutBatiment, int quantiteRessource, int priorite)
        {
            CoordoX = coordoX;
            CoordoY = coordoY;
            StatutBatiment = statutBatiment;
            QuantiteRessource = quantiteRessource;
            Priorite = priorite;
        }
        
        
    }
    public enum Statut 
    { 
        parfait,
        necessiteReparation,
        aDemolir
    };

}
