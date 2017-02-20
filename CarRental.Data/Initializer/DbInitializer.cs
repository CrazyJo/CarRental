﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace CarRental.Data.Initializer
{
    public class DbInitializer : CreateDatabaseIfNotExists<CarRentalModelContainer>
    {
        protected override void Seed(CarRentalModelContainer context)
        {
            SeedUsers(context);
            SeedAuthInfoRole(context);
            SeedCars(context);
            SeddCarDetails(context);
            SeedPriceList(context);
            SeedParking(context);
            SeedOrders(context);
            SeedRentalDetails(context);

            context.SaveChanges();
            base.Seed(context);
        }

        void SeedUsers(CarRentalModelContainer context)
        {
            context.People.AddRange(new List<Person>
            {
                new Person
                {
                    Id = 1,
                    FirsName = "admin",
                    LastName = "admin"
                },
                new Person
                {
                    Id = 2,
                    FirsName = "Alan",
                    LastName = "MacConahi"
                },
                new Person
                {
                    Id = 3,
                    FirsName = "Malcolm",
                    LastName = "Peterson"
                }
            });
        }
        void SeedAuthInfoRole(CarRentalModelContainer context)
        {
            var a1 = new AuthInfo
            {
                Id = 1,
                PersonId = 1,
                UserName = "admin",
                Password = "admin"
            };
            var a2 = new AuthInfo
            {
                Id = 2,
                PersonId = 2,
                UserName = "user2",
                Password = "user2"
            };
            var a3 = new AuthInfo
            {
                Id = 3,
                PersonId = 3,
                UserName = "user3",
                Password = "user3"
            };

            var r1 = new Role
            {
                Id = 1,
                Name = UserRole.Manager                
            };
            var r2 = new Role
            {
                Id = 2,
                Name = UserRole.Customer
            };

            r1.AuthInfo.Add(a1);
            a1.Role.Add(r1);

            r2.AuthInfo.Add(a2);
            r2.AuthInfo.Add(a3);
            a2.Role.Add(r2);
            a3.Role.Add(r2);

            context.AuthInfoes.AddOrUpdate(a1, a2, a3);
            context.Roles.AddOrUpdate(r1, r2);
        }
        void SeedCars(CarRentalModelContainer context)
        {
            context.Cars.AddRange(new List<Car>
            {
                new Car
                {
                    Id = 1,
                    Name = "Mercedes S500"
                },
                new Car
                {
                    Id=2,
                    Name = "Audi A4"
                },
                new Car
                {
                    Id=3,
                    Name = "BMV M3"
                }
            });
        }
        void SeddCarDetails(CarRentalModelContainer context)
        {
            context.CarDetails.AddRange(new List<CarDetail>
            {
                new CarDetail
                {
                    CarId = 1,
                    Color = "Black"
                },
                new CarDetail
                {
                    CarId = 2,
                    Color = "Blue"
                },
                new CarDetail
                {
                    CarId = 3,
                    Color = "Red"
                }
            });
        }
        void SeedPriceList(CarRentalModelContainer context)
        {
            context.PriceList.AddRange(new List<PriceItem>
            {
                new PriceItem
                {
                    CarId = 1,
                    PricePerHour = 78.45
                },
                new PriceItem
                {
                    CarId = 2,
                    PricePerHour = 91.15
                },
                new PriceItem
                {
                    CarId = 3,
                    PricePerHour = 71.99
                }
            });
        }
        void SeedParking(CarRentalModelContainer context)
        {
            context.Parking.AddRange(new List<ParkingItem>
            {
                new ParkingItem
                {
                    CarId = 1,
                    Balance = 3,
                    TotalCars = 4
                },
                new ParkingItem
                {
                    CarId = 2,
                    Balance = 2,
                    TotalCars = 3
                },
                new ParkingItem
                {
                    CarId = 1,
                    Balance = 2,
                    TotalCars = 2
                }
            });
        }
        void SeedOrders(CarRentalModelContainer context)
        {
            context.Rents.AddRange(new List<Rent>
            {
                new Rent
                {
                    Id = 1,
                    PersonId = 2,
                    DateRental = DateTime.Now.Subtract(new TimeSpan(8, 0, 0))
                },
                new Rent
                {
                    Id = 2,
                    PersonId = 3,
                    DateRental = DateTime.Now.Subtract(new TimeSpan(15, 0, 0))
                }
            });
        }
        void SeedRentalDetails(CarRentalModelContainer context)
        {
            context.RentalDetails.AddRange(new List<RentalDetail>
            {
                new RentalDetail
                {
                    CarId = 1,
                    RentId = 1,
                    Lease = new TimeSpan(12, 9, 0)
                },
                new RentalDetail
                {
                    CarId = 2,
                    RentId = 2,
                    Lease = new TimeSpan(30, 8, 0)
                }
            });
        }
    }
}