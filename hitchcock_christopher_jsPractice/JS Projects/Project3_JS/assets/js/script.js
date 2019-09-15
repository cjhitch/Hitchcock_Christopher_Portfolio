(function(){

    ml = {
        selectors : {
            btnSelector: document.querySelector('button'),
            nameDisplay: document.querySelector('section.nameDisplay h3'),
            animalR: document.querySelector('.animalRow'),
            anotherNR: document.querySelector('.anotherNameRow'),
            adjR: document.querySelector('.adjRow'),
            foodR: document.querySelector('.foodRow'),
            yearR: document.querySelector('.yearRow'),
            costR: document.querySelector('.costRow'),
            randR: document.querySelector('.randRow'),
            story: document.querySelector('.storyArea'),
        },
        values : {
            name: document.querySelector('input.name').value,
            animal: document.querySelector('input.animal'),
            otherName: document.querySelector('input.otherName'),
            adj: document.querySelector('input.adj'),
            food: document.querySelector('input.food'),
            year: document.querySelector('input.year'),
            cost: document.querySelector('input.cost'),
            rand: document.querySelector('input.rand'),
            numArray: []
        },
        method: {
            // once hit submit, welcome user
            setName : function() {               
                ml.selectors.nameDisplay.innerHTML = `<br>Welcome to Our MadLibs Story Game ${ml.values.name}</h3><h5><br>We will ask for a series of responses, once you have answered all of them, we'll have a fun story for you.<br>We hope you enjoy!</h5><h3>`;
                ml.selectors.animalR.classList.remove('d-none');
            },
            listener : function() {
                ml.values.animal.addEventListener('input', function(e){
                    if (ml.values.animal.value != "") {
                        ml.selectors.anotherNR.classList.remove('d-none');
                    }
                    else {
                        ml.selectors.anotherNR.classList.add('d-none');
                    }
                })
                ml.values.otherName.addEventListener('input', function(e){
                    if (ml.values.otherName.value != "") {
                        ml.selectors.adjR.classList.remove('d-none');
                    }
                    else {
                        ml.selectors.adjR.classList.add('d-none');
                    }
                })
                ml.values.adj.addEventListener('input', function(e){
                    if (ml.values.adj.value != "") {
                        ml.selectors.foodR.classList.remove('d-none');
                    }
                    else {
                        ml.selectors.foodR.classList.add('d-none');
                    }
                })
                ml.values.food.addEventListener('input', function(e){
                    if (ml.values.food.value != "") {
                        ml.selectors.yearR.classList.remove('d-none');
                    }
                    else {
                        ml.selectors.yearR.classList.add('d-none');
                    }
                })
                ml.values.year.addEventListener('input', function(e){
                    if (ml.values.year.value != "") {
                        ml.selectors.costR.classList.remove('d-none');
                    }
                    else {
                        ml.selectors.costR.classList.add('d-none');
                    }
                })
                ml.values.cost.addEventListener('input', function(e){
                    if (ml.values.cost.value != "") {
                        ml.selectors.randR.classList.remove('d-none');
                    }
                    else {
                        ml.selectors.randR.classList.add('d-none');
                    }
                })
                ml.values.rand.addEventListener('input', function(e){
                    if (ml.values.rand.value != "") {
                        ml.method.writeStory();
                    }
                    else {
                        ml.selectors.story.classList.add('d-none');
                    }
                })
            },
            writeStory: function(){
                ml.values.numArray = [ml.values.year, ml.values.cost, ml.values.rand];
                var story = `The year was ${ml.values.numArray[0].value} A.D. on the planet Exo-homarcee-itis Ven IV, and the world was a very different place. In fact, at that time a gallon of milk was only \$${ml.values.numArray[1].value}. This is where our fearless hero enters the picture. Meet ${ml.values.otherName.value} the ${ml.values.adj.value}. ${ml.values.otherName.value} was a member of the race of ${ml.values.animal.value}s that filled the planet of Exo-homarcee-itis Ven IV. Now ${ml.values.otherName.value} wasn't always ${ml.values.adj.value}, in fact, this was a relatively new development in our story. ${ml.values.otherName.value} was considered the laughing stock of the scientific community as a failed scientist in the art of ${ml.values.food.value}. One day, not too long ago, while ${ml.values.otherName.value} was working on the newest attempt at Cadbury Creme Egg filled ${ml.values.food.value}, existence on this planet was forever changed as we now know it. Unbenownst to ${ml.values.otherName.value} , ${ml.values.otherName.value} had mixed the exact ingredients we now know creates a portal through time itself! With this accidental discovery, ${ml.values.otherName.value} was sucked through the portal ${ml.values.numArray[2].value} years back in time. Only then did ${ml.values.otherName.value} meet the Old Masters of ${ml.values.food.value} Chef Clan. It was only in that 27 minutes of exhaustive research and studying with ${ml.values.food.value} Chef Clan, that ${ml.values.otherName.value} forever was changed, as ${ml.values.otherName.value} was dubbed ${ml.values.otherName.value} The ${ml.values.adj.value}, the highest achievable title for a ${ml.values.animal.value}. Those 27 minutes flew by in what seemed like only minutes. When ${ml.values.otherName.value} had learned everything that could be learned from the ${ml.values.food.value} Chef Clan, ${ml.values.otherName.value} stirred the concoction again, to travel forward again to the year year ${ml.values.year.value} A.D. When ${ml.values.otherName.value} shared everything about the ${ml.values.food.value} recipes with the scientific community, ${ml.values.otherName.value} finally became a respected member of the scientific community, and since that day has forever been remembered as ${ml.values.otherName.value} The ${ml.values.adj.value}. The planet of ${ml.values.animal.value}s will always remember that day when ${ml.values.food.value} were finally perfected and became the most amazing food a ${ml.values.animal.value} has ever known. Where will ${ml.values.otherName.value} The ${ml.values.adj.value} go next?!`;
                ml.selectors.story.innerHTML = story;
            }
        }
    }
        // set up the event listener and initialized the setname and listener function
    ml.selectors.btnSelector.addEventListener('click', function(e){
        ml.method.setName();
        ml.method.listener();
    })

})();