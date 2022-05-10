// <copyright file="Initialize.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MovieRental.Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ConsoleTools;
    using MovieRental.Data;
    using MovieRental.Logic;

    /// <summary>
    /// Initialize class contains the consolemenu and its methods for the menu items.
    /// </summary>
    internal class Initialize
    {
        static RestService rest;

        private static void Main()
        {
            RentFactory f1 = new RentFactory();

            ConsoleMenu menu = new ConsoleMenu()
                .Add("-- Select a movie --", () => GetOneMovie(f1.MovieLogic))
                .Add("-- Select a rent --", () => GetOneRent(f1.RentLogic))
                .Add("-- Select a renter --", () => GetOneRenter(f1.RentLogic))
                .Add("-- Select a staff --", () => GetOneStaff(f1.MovieLogic))
                .Add("-- List all of the movies --", () => GetAllMovies(f1.MovieLogic))
                .Add("-- List all of the rents --", () => GetAllRents(f1.RentLogic))
                .Add("-- List all of the renters --", () => GetAllRenters(f1.RentLogic))
                .Add("-- List all of the staffs --", () => GetAllStaffs(f1.MovieLogic))
                .Add("-- Change the title of a movie --", () => ChangeMovieTitle(f1.MovieLogic))
                .Add("-- Change the distributor of a movie --", () => ChangeMovieDistributor(f1.MovieLogic))
                .Add("-- Change the category of a movie --", () => ChangeMovieCategory(f1.MovieLogic))
                .Add("-- Change the order of a rent --", () => ChangeRentOrder(f1.RentLogic))
                .Add("-- Change the price of a rent --", () => ChangeRentPrice(f1.RentLogic))
                .Add("-- Change the overrun fee of a rent --", () => ChangeRentOverrunFee(f1.RentLogic))
                .Add("-- Change the name of a renter --", () => ChangeRenterName(f1.RentLogic))
                .Add("-- Change the city of a renter --", () => ChangeRenterCity(f1.RentLogic))
                .Add("-- Change the street of a renter --", () => ChangeRenterStreet(f1.RentLogic))
                .Add("-- Change the house number of a renter --", () => ChangeRenterHouseNumber(f1.RentLogic))
                .Add("-- Change the director of a staff --", () => ChangeStaffDirector(f1.MovieLogic))
                .Add("-- Change the main character of a staff --", () => ChangeStaffMainCharacter(f1.MovieLogic))
                .Add("-- Change the cost of a staff --", () => ChangeStaffCost(f1.MovieLogic))
                .Add("-- Change the studio of a staff --", () => ChangeStaffStudio(f1.MovieLogic))
                .Add("-- Delete a movie --", () => DeleteMovie(f1.MovieLogic))
                .Add("-- Delete a rent --", () => DeleteRent(f1.RentLogic))
                .Add("-- Delete a renter --", () => DeleteRenter(f1.RentLogic))
                .Add("-- Delete a staff --", () => DeleteStaff(f1.MovieLogic))
                .Add("-- Create a movie --", () => CreateMovie(f1.MovieLogic))
                .Add("-- Create a rent --", () => CreateRent(f1.RentLogic))
                .Add("-- Create a renter --", () => CreateRenter(f1.RentLogic))
                .Add("-- Create a staff --", () => CreateStaff(f1.MovieLogic))
                .Add("-- The average cost of movies grouped by categories --", () => AverageCost(f1.MovieLogic))
                .Add("-- The sum of supporting characters grouped by distributors --", () => SumCharacterNumber(f1.MovieLogic))
                .Add("-- The sum of prices grouped by cities --", () => SumPrice(f1.RentLogic))
                .Add("-- Task: The average cost of movies grouped by categories --", () => AverageCostAsync(f1.MovieLogic))
                .Add("-- Task: The sum of supporting characters grouped by distributors --", () => SumCharacterNumberAsync(f1.MovieLogic))
                .Add("-- Task: The sum of prices grouped by cities --", () => SumPriceAsync(f1.RentLogic))
                .Add("-- Exit from the menu --", ConsoleMenu.Close);

            menu.Show();
        }

        private static void GetOneMovie(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            string number = Console.ReadLine();

            rest.GetSingle<Movie>("movie");

            if (number != null)
            {
                int id = int.Parse(number, null);
                if (id > 0 && id < 11)
                {
                    var q = logic.GetOneMovie(id);

                    Console.WriteLine("\n The selected movie: \n");
                    Console.WriteLine(q);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The selected Id does not exist.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong input. It is not a number.");
                Console.ReadLine();
            }
        }

        private static void GetOneRent(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            string number = Console.ReadLine();

            if (number != null)
            {
                int id = int.Parse(number, null);
                if (id > 0 && id < 11)
                {
                    var q = logic.GetOneRent(id);

                    Console.WriteLine("\n The selected rent: \n");
                    Console.WriteLine(q);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The selected Id does not exist.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong input. It is not a number.");
                Console.ReadLine();
            }
        }

        private static void GetOneRenter(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            string number = Console.ReadLine();

            if (number != null)
            {
                int id = int.Parse(number, null);
                if (id > 0 && id < 11)
                {
                    var q = logic.GetOneRenter(id);

                    Console.WriteLine("\n The selected renter: \n");
                    Console.WriteLine(q);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The selected Id does not exist.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong input. It is not a number.");
                Console.ReadLine();
            }
        }

        private static void GetOneStaff(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            string number = Console.ReadLine();

            if (number != null)
            {
                int id = int.Parse(number, null);
                if (id > 0 && id < 11)
                {
                    var q = logic.GetOneStaff(id);

                    Console.WriteLine("\n The selected staff: \n");
                    Console.WriteLine(q);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The selected Id does not exist.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong input. It is not a number.");
                Console.ReadLine();
            }
        }

        private static void GetAllMovies(MovieLogic logic)
        {
            Console.WriteLine("\n All of the movies: \n");

            logic.GetAllMovies().ToList().ForEach(x => Console.WriteLine(x.MainData));

            List<Movie> movies = rest.Get<Movie>("movie");

            Console.ReadLine();
        }

        private static void GetAllRents(RentLogic logic)
        {
            Console.WriteLine("\n All of the rents: \n");

            logic.GetAllRents().ToList().ForEach(x => Console.WriteLine(x.MainData));

            Console.ReadLine();
        }

        private static void GetAllRenters(RentLogic logic)
        {
            Console.WriteLine("\n All of the renters: \n");

            logic.GetAllRenters().ToList().ForEach(x => Console.WriteLine(x.MainData));

            Console.ReadLine();
        }

        private static void GetAllStaffs(MovieLogic logic)
        {
            Console.WriteLine("\n All of the staffs: \n");

            logic.GetAllStaffs().ToList().ForEach(x => Console.WriteLine(x.MainData));

            Console.ReadLine();
        }

        private static void ChangeMovieTitle(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            Movie one = rest.Get<Movie>(id, "movie");
            rest.Put<Movie>(one, "movie");

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new title here: ");
                string newTitle = Console.ReadLine();

                logic.ChangeMovieTitle(id, newTitle);
                var q = logic.GetOneMovie(id);

                Console.WriteLine("\n The new title: \n");
                Console.WriteLine(q.Title);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeMovieDistributor(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new distributor here: ");
                string newDistributor = Console.ReadLine();

                logic.ChangeMovieDistributor(id, newDistributor);
                var q = logic.GetOneMovie(id);

                Console.WriteLine("\n The new distributor: \n");
                Console.WriteLine(q.Distributor);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeMovieCategory(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new category here: ");
                string newCategory = Console.ReadLine();

                logic.ChangeMovieCategory(id, newCategory);
                var q = logic.GetOneMovie(id);

                Console.WriteLine("\n The new category: \n");
                Console.WriteLine(q.Category);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeMovieLength(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new length here(__ minutes): ");
                string newLength = Console.ReadLine();

                logic.ChangeMovieLength(id, newLength);
                var q = logic.GetOneMovie(id);

                Console.WriteLine("\n The new length: \n");
                Console.WriteLine(q.Length);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeMovieLanguage(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new language here: ");
                string newLanguage = Console.ReadLine();

                logic.ChangeMovieLanguage(id, newLanguage);
                var q = logic.GetOneMovie(id);

                Console.WriteLine("\n The new language: \n");
                Console.WriteLine(q.Language);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeRentOrder(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new order here (YYYY, MM, DD): ");
                DateTime newOrder = DateTime.Parse(Console.ReadLine(), null);

                logic.ChangeRentOrder(id, newOrder);
                var q = logic.GetOneRent(id);

                Console.WriteLine("\n The new order: \n");
                Console.WriteLine(q.Order);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeRentPrice(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new price here: ");
                int newPrice = int.Parse(Console.ReadLine(), null);

                logic.ChangeRentPrice(id, newPrice);
                var q = logic.GetOneRent(id);

                Console.WriteLine("\n The new price: \n");
                Console.WriteLine(q.Price);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeRentRentalStart(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new start of the rental here (YYYY, MM, DD): ");
                DateTime newRentalStart = DateTime.Parse(Console.ReadLine(), null);

                logic.ChangeRentRentalStart(id, newRentalStart);
                var q = logic.GetOneRent(id);

                Console.WriteLine("\n The new start of the rental: \n");
                Console.WriteLine(q.RentalStart);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeRentRentalEnd(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new end of the rental here (YYYY, MM, DD): ");
                DateTime newRentalEnd = DateTime.Parse(Console.ReadLine(), null);

                logic.ChangeRentRentalEnd(id, newRentalEnd);
                var q = logic.GetOneRent(id);

                Console.WriteLine("\n The new end of the rental: \n");
                Console.WriteLine(q.RentalEnd);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeRentOverrunFee(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new overrun fee here: ");
                int newOverrunFee = int.Parse(Console.ReadLine(), null);

                logic.ChangeRentOverrunFee(id, newOverrunFee);
                var q = logic.GetOneRent(id);

                Console.WriteLine("\n The new overrun fee: \n");
                Console.WriteLine(q.OverrunFee);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeRenterName(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new name here: ");
                string newName = Console.ReadLine();

                logic.ChangeRenterName(id, newName);
                var q = logic.GetOneRenter(id);

                Console.WriteLine("\n The new name: \n");
                Console.WriteLine(q.Name);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeRenterPostcode(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new postcode here: ");
                int newPostcode = int.Parse(Console.ReadLine(), null);

                logic.ChangeRenterPostcode(id, newPostcode);
                var q = logic.GetOneRenter(id);

                Console.WriteLine("\n The new postcode: \n");
                Console.WriteLine(q.Postcode);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeRenterCity(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new city here: ");
                string newCity = Console.ReadLine();

                logic.ChangeRenterCity(id, newCity);
                var q = logic.GetOneRenter(id);

                Console.WriteLine("\n The new city: \n");
                Console.WriteLine(q.City);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeRenterStreet(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new street here: ");
                string newStreet = Console.ReadLine();

                logic.ChangeRenterStreet(id, newStreet);
                var q = logic.GetOneRenter(id);

                Console.WriteLine("\n The new street: \n");
                Console.WriteLine(q.Street);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeRenterHouseNumber(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new house number here: ");
                string newHouseNumber = Console.ReadLine();

                logic.ChangeRenterHouseNumber(id, newHouseNumber);
                var q = logic.GetOneRenter(id);

                Console.WriteLine("\n The new house number: \n");
                Console.WriteLine(q.HouseNumber);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeRenterMembershipStart(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new start of the membership here (YYYY, MM, DD) : ");
                DateTime newMembershipStart = DateTime.Parse(Console.ReadLine(), null);

                logic.ChangeRenterMembershipStart(id, newMembershipStart);
                var q = logic.GetOneRenter(id);

                Console.WriteLine("\n The new start of the membership: \n");
                Console.WriteLine(q.MembershipStart);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeRenterMembershipEnd(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new end of the membership here (YYYY, MM, DD) : ");
                DateTime newMembershipEnd = DateTime.Parse(Console.ReadLine(), null);

                logic.ChangeRenterMembershipEnd(id, newMembershipEnd);
                var q = logic.GetOneRenter(id);

                Console.WriteLine("\n The new end of the membership: \n");
                Console.WriteLine(q.MembershipEnd);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeStaffDirector(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new director here: ");
                string newDirector = Console.ReadLine();

                logic.ChangeStaffDirector(id, newDirector);
                var q = logic.GetOneStaff(id);

                Console.WriteLine("\n The new director: \n");
                Console.WriteLine(q.Director);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeStaffMainCharacter(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new main character here: ");
                string newMainCharacter = Console.ReadLine();

                logic.ChangeStaffMainCharacter(id, newMainCharacter);
                var q = logic.GetOneStaff(id);

                Console.WriteLine("\n The new main character: \n");
                Console.WriteLine(q.MainCharacter);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeStaffSupportingCharacters(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new number of supporting characters here: ");
                int newSupportingCharacters = int.Parse(Console.ReadLine(), null);

                logic.ChangeStaffSupportingCharacters(id, newSupportingCharacters);
                var q = logic.GetOneStaff(id);

                Console.WriteLine("\n The new number of supporting characters: \n");
                Console.WriteLine(q.SupportingCharacters);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeStaffCost(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new cost here: ");
                int newCost = int.Parse(Console.ReadLine(), null);

                logic.ChangeStaffCost(id, newCost);
                var q = logic.GetOneStaff(id);

                Console.WriteLine("\n The new cost: \n");
                Console.WriteLine(q.Cost);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void ChangeStaffStudio(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                Console.WriteLine("Enter the new studio here: ");
                string newStudio = Console.ReadLine();

                logic.ChangeStaffStudio(id, newStudio);
                var q = logic.GetOneStaff(id);

                Console.WriteLine("\n The new studio: \n");
                Console.WriteLine(q.Studio);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void DeleteMovie(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            rest.Delete(id, "movie");

            if (id > 0 && id < 11)
            {
                logic.DeleteMovie(id);

                Console.WriteLine("The selected Id successfully deleted.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void DeleteRent(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                logic.DeleteRent(id);

                Console.WriteLine("The selected Id successfully deleted.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void DeleteRenter(RentLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                logic.DeleteRenter(id);

                Console.WriteLine("The selected Id successfully deleted.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void DeleteStaff(MovieLogic logic)
        {
            Console.WriteLine("Enter the selected Id: ");
            int id = int.Parse(Console.ReadLine(), null);

            if (id > 0 && id < 11)
            {
                logic.DeleteStaff(id);

                Console.WriteLine("The selected Id successfully deleted.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The selected Id does not exist.");
                Console.ReadLine();
            }
        }

        private static void CreateMovie(MovieLogic logic)
        {
            Console.WriteLine("Enter the title here: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the distributor here: ");
            string distributor = Console.ReadLine();

            Console.WriteLine("Enter the category here: ");
            string category = Console.ReadLine();

            Console.WriteLine("Enter the length here(__ minutes): ");
            string length = Console.ReadLine();

            Console.WriteLine("Enter the language here: ");
            string language = Console.ReadLine();

            Console.WriteLine("Enter the rentId here(between 1 and 10): ");
            int rentId = int.Parse(Console.ReadLine(), null);

            logic.CreateMovie(title, distributor, category, length, language, rentId);

            rest.Post(new Movie() { Title = title, Distributor = distributor, Category = category, Length = length, Language = language, RentId = rentId }, "movie");

            Console.WriteLine("\n The movie successfully created. \n");
            Console.ReadLine();
        }

        private static void CreateRent(RentLogic logic)
        {
            Console.WriteLine("Enter the order here(YYYY, MM, DD): ");
            DateTime order = DateTime.Parse(Console.ReadLine(), null);

            Console.WriteLine("Enter the price here: ");
            int price = int.Parse(Console.ReadLine(), null);

            Console.WriteLine("Enter the start of the rental here(YYYY, MM, DD): ");
            DateTime rentalStart = DateTime.Parse(Console.ReadLine(), null);

            Console.WriteLine("Enter the end of the rental here(YYYY, MM, DD): ");
            DateTime rentalEnd = DateTime.Parse(Console.ReadLine(), null);

            Console.WriteLine("Enter the overrun fee here: ");
            int overrunFee = int.Parse(Console.ReadLine(), null);

            logic.CreateRent(order, price, rentalStart, rentalEnd, overrunFee);

            Console.WriteLine("\n The rent successfully created. \n");
            Console.ReadLine();
        }

        private static void CreateRenter(RentLogic logic)
        {
            Console.WriteLine("Enter the name here: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the postcode here: ");
            int postcode = int.Parse(Console.ReadLine(), null);

            Console.WriteLine("Enter the city here: ");
            string city = Console.ReadLine();

            Console.WriteLine("Enter the street here: ");
            string street = Console.ReadLine();

            Console.WriteLine("Enter the house number here: ");
            string houseNumber = Console.ReadLine();

            Console.WriteLine("Enter the start of the membership here(YYYY, MM, DD): ");
            DateTime membershipStart = DateTime.Parse(Console.ReadLine(), null);

            Console.WriteLine("Enter the end of the membership here(YYYY, MM, DD): ");
            DateTime membershipEnd = DateTime.Parse(Console.ReadLine(), null);

            Console.WriteLine("Enter the rentId here(between 1 and 10): ");
            int rentId = int.Parse(Console.ReadLine(), null);

            logic.CreateRenter(name, postcode, city, street, houseNumber, membershipStart, membershipEnd, rentId);

            Console.WriteLine("\n The renter successfully created. \n");
            Console.ReadLine();
        }

        private static void CreateStaff(MovieLogic logic)
        {
            Console.WriteLine("Enter the director here: ");
            string director = Console.ReadLine();

            Console.WriteLine("Enter the main character here: ");
            string mainCharacter = Console.ReadLine();

            Console.WriteLine("Enter the number of supporting characters here: ");
            int supportingCharacters = int.Parse(Console.ReadLine(), null);

            Console.WriteLine("Enter the cost here: ");
            int cost = int.Parse(Console.ReadLine(), null);

            Console.WriteLine("Enter the studio here: ");
            string studio = Console.ReadLine();

            Console.WriteLine("Enter the movieId here(between 1 and 10): ");
            int movieId = int.Parse(Console.ReadLine(), null);

            logic.CreateStaff(director, mainCharacter, supportingCharacters, cost, studio, movieId);

            Console.WriteLine("\n The staff successfully created. \n");
            Console.ReadLine();
        }

        private static void AverageCost(MovieLogic logic)
        {
            Console.WriteLine("Movies' average costs grouped by categories: ");

            var q = logic.AverageCost();

            foreach (var movie in q)
            {
                Console.WriteLine(movie.ToString());
            }

            Console.ReadLine();
        }

        private static void SumCharacterNumber(MovieLogic logic)
        {
            Console.WriteLine("Movies' sum of supporting characters' number grouped by distributors: ");

            var q = logic.SumCharacternumber();

            foreach (var movie in q)
            {
                Console.WriteLine(movie.ToString());
            }

            Console.ReadLine();
        }

        private static void SumPrice(RentLogic logic)
        {
            Console.WriteLine("Rents' sum of prices grouped by cities: ");

            var q = logic.SumPrice();

            foreach (var rent in q)
            {
                Console.WriteLine(rent.ToString());
            }

            Console.ReadLine();
        }

        private static void AverageCostAsync(MovieLogic logic)
        {
            Console.WriteLine("Movies' average costs grouped by categories: ");

            var task = logic.AverageCostAsync();
            var result = task.Result;

            foreach (var movie in result)
            {
                Console.WriteLine(movie);
            }

            Console.ReadLine();
        }

        private static void SumCharacterNumberAsync(MovieLogic logic)
        {
            Console.WriteLine("Movies' sum of supporting characters' number grouped by distributors: ");

            var task = logic.SumCharacternumberAsync();
            var result = task.Result;

            foreach (var movie in result)
            {
                Console.WriteLine(movie);
            }

            Console.ReadLine();
        }

        private static void SumPriceAsync(RentLogic logic)
        {
            Console.WriteLine("Rents' sum of prices grouped by cities: ");

            var task = logic.SumPriceAsync();
            var result = task.Result;

            foreach (var rent in result)
            {
                Console.WriteLine(rent);
            }

            Console.ReadLine();
        }
    }
}
