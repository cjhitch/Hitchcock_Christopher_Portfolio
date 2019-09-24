(function(){

    console.log("hello?!?!?!");

    class Vehicle {
        constructor(type ,wheels, drive){
            this._type = type;
            this._wheels = wheels;
            this._drive = drive;
        }
        vehicleInfo(){
            console.log(`This ${this._type} uses a ${this._drive} engine and has this many wheels: ${this._wheels}`);
        }
    }

    var dumpTruck = new Vehicle("dump truck",10, "diesel");
    dumpTruck.vehicleInfo();

    console.log("\n")

    class Car extends Vehicle {
        constructor(year, make, model) {
            super("car",4, "gasoline");
            this._year = year;
            this._make = make;
            this._model = model;
        }
        carInfo(){
            console.log(`What a beauty! This ${this._year} ${this._make} ${this._model} is a dream car!`);
        }
    }

    var belAir = new Car(1957, "Chevrolet", "Bel Air");
    belAir.vehicleInfo();
    belAir.carInfo();
    console.log("\n")

    class SpaceShip extends Vehicle {
        constructor(description, fuelType) {
            super("Interstellar Dreadnaught", "None! I have landing gear", "hyperspace");
            this._description = description;
            this._fuelType = fuelType;
        }
        shipInfo(){
            console.log(`What makes this ship so ${this._description} is the ${this.fuelType} fuel that runs the hyperspace drive.`)
        }
    }

    var dreadnaught = new SpaceShip("fast", "dark matter");
    dreadnaught.vehicleInfo();
    dreadnaught.shipInfo();


    // For OOP I created three objects, the first was a vehicle super class. This class uses abstraction to show only relevant data of type of vehicle, wheels, and type of drive.
    // I had originally included things like colors, amount of doors, and seats, but for the methods they were irrelevant and I removed them. For encapsulation, I utilized what are 
    // considered private member variables in ES6 by having the variables use the underscore in front of the variable name. My understanding is this doesn't make them truly private
    // as we can with C# by using a private declaration, but it helps other developers know they are intended to be. For polymorphism, both of my classes that inherited from the base
    // class, tapped into the main vehicleInfo method to display relevant data about the vehicle. Lastly, as just mentioned in the past sentence, the classes spaceship and car
    // use inheritance to set all the base vehicle variables for the constructor and then extend with their own relevant variables.

})();