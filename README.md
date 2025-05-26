# ImagineCars, Code Test
This is a small code test for some C# development for the fictitious 'RCM' company, ImagineCars.

## How to Run
The prerequisites are:
- Your favourite code editor (but I would recommend using Visual Studio, or you'll potentially have to build and run through CLI)
- Docker Desktop (or similar) (https://docs.docker.com/desktop/)
- Docker Compose (https://docs.docker.com/compose/install/)
- Dotnet toolchain (And Entity Framework) (https://learn.microsoft.com/en-us/ef/core/cli/dotnet)

(You may also _not_ opt to use docker, and run postgres locally, but you will have to ensure you have configured it properly in the Program.cs file.)

Clone the repo, cd into the working directory, run `docker-compose up` (or `docker compose up`) while Docker Desktop is available.
A postgres instance should now be running on port 5432.

In another terminal, access the working directory and run:
`dotnet ef database update`

This will apply the migrations to your database, thus creating the Workshop table.

You are now up and running, and can with Visual Studio just run the software, you should see a swagger page at http://localhost:5256.

## Well, now what?
1. Look around in the repository and try to familiarize yourself with what is going on.
2. Start implementing AddWorkshopToCompany in the WorkshopsController.cs, everything should already be available.
3. Once you have succesfully added some workshops, finish the GetWorkshops function in the same controller.

Do your best to follow the existing structure, but feel free to add any new classes you think are necessary.
It is important you develop the endpoints as if these were outwardly facing (i.e. accessible by the public).


Any use large language models is obviously discouraged, but we can't stop you.

## How much time should I spend on this?
The test is supposed to be pretty short, but it can obviously take some time to set up the environment to run properly.

If we disregard the "setup time", the expected time you should spend is around 1 hour.

When you are done, you may notify us by email, and we will book a meeting to go over your solutions remotely.
