﻿/* Задача 21
Напишите программу, 
которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int[] A = {7, -5, 0}; 
int[] B = {1, -1, 9};
double distance = Math.Sqrt((Math.Pow((B[0]-A[0]), 2)) + (Math.Pow((B[1]-A[1]), 2)) + (Math.Pow((B[2]-A[2]), 2)));

Console.WriteLine("Расстояние между точками равно: " + distance);