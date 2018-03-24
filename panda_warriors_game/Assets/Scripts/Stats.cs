using UnityEngine;

namespace GameCore.Player
{
    public class Stats : MonoBehaviour
    {
        public class Player
        {
            int crystals = 0;
            int scrap = 0;
            int antymatery = 0;
        }

        public static class Robotnik
        {
            static int health = 50;
        }

        public static class Dekonstruktor
        {
            static int health = 100;
        }

        public static class Ergatis
        {
            static int health = 100;
            static int damage = 20;
        }

        public static class Asystent
        {
            static int health = 180;
            static int damage = 30;
        }

        public static class Piramidos
        {
            static int health = 200;
            static int damage = 45;
        }

        public static class DZD
        {
            static int health = 250;
            static int damage = 80;
        }

        public static class P4TK
        {
            static int health = 500;
            static int damage = 120;
        }

        public static class CentrumDowodzenia
        {
            static int health = 5000;
        }

        public static class Koszary
        {
            static int health = 1000;
        }

        public static class Zbrojownia
        {
            static int health = 1000;
        }

        public static class Instytut
        {
            static int health = 1000;
        }

        public static class Reaktor
        {
            static int health = 600;
        }
    }
}