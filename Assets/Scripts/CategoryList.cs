/*
The category name to filter on.
The supported categories can be found in https://lightship.dev/docs/ardk/features/object_detection/
*/
public enum CategoryList
{
    //Aircraft
    airplane, helicopter, hot_air_balloon, parachute, rocket,
    //Building features
    door, door_handle, window,
    //Car
    car, taxi,
    //Outdoor furniture
    barrel, bench, billboard, fire_hydrant, flag, parking_meter, sculpture, snowman, street_light, traffic_light, waste_container,
    //Vehicle
    vehicle, bicycle, boat, bus, /*car,*/ cart, motorcycle, /*taxi,*/ train, truck, wheel, wheelchair,
    //Water feature
    fountain, swimming_pool,
    //Accessories
    backpack, glasses, handbag, umbrella,
    //Clothing
    coat, dress, shirt, shorts, skirt, sock, suit, tie, trousers,
    //Footwear
    footwear, roller_skates,
    //Headwear
    headwear, fedora,
    //Musical instrument
    accordion, brass_instrument, drum, flute, guitar, piano, string_instrument, violin,
    //Brass instrument
    french_horn, saxophone, trombone, trumpet,
    //String instrument
    banjo, cello, harp, /*guitar, violin,*/
    //Food
    food, apple, banana, berry, bread, broccoli, cake, carrot, cheese, citrus, coconut,
    dessert, donut, egg, fast_food, grape, hamburger, hot_dog, ice_cream, mushroom, pear, pizza, pumpkin, sandwich, sushi, tomato,
    //Berry
    /*berry,*/
    raspberry, strawberry,
    //Citrus
    /*citrus,*/
    grapefruit, lemon, lime, orange,
    //Dessert
    /*dessert, cake, donut, ice_cream,*/
    //Fast food
    /*fast_food,*/
    french_fries, /*hot_dog, pizza, hamburger, sandwich,*/
    //Pumpkin
    /*pumpkin,*/
    squash,
    //Drink
    drink, hot_drink, juice,
    //Hot Drink (recognized when in a cup)
    tea, coffee,
    //Appliances
    hair_dryer, microwave, oven, refrigerator, toaster,
    //Cooking pan
    frying_pan, pressure_cooker, slow_cooker, waffle_iron, wok,
    //Indoor furniture
    furniture, bed, chair, christmas_tree, couch, curtains, poster, shelves, storage_cabinet, table,
    //Jug
    jug, teapot,
    //Lamp
    lamp, candle,
    //Home features
    bathtub, fireplace, sink, tap, toilet,
    //Miscellaneous items
    book, bottle, bowl, box, cannon, chopsticks, coin, cup, flowerpot,
    fork, knife, pen, pillow, plate, potted_plant, scissors, skull, spoon, tin_can, toothbrush, wine_glass,
    //Screen
    screen, computer_display, tablet, TV,
    //Sports ball
    sports_ball, football, rugby_ball, tennis_ball,
    //Sports equipment
    baseball_bat, baseball_glove, frisbee, kite, paddle, skateboard, skis, snowboard, tennis_racket,
    //Tech
    camera, clock, computer_keyboard, computer_mouse, headphones, microphone, phone, remote, watch,
    //Toy
    toy, doll, teddy_bear,
    //Animal
    animal, alpaca, bear, big_cat, bird, camel, cat, cow, crocodile, deer, dog, dolphin, elephant, fish,
    frog, giraffe, goldfish, hippopotamus, horse, jellyfish, kangaroo, panda, parrot, pig, polar_bear,
    rabbit, reptile, rhinoceros, seal, sheep, shellfish, squirrel, turtle, water_bird, whale, zebra,
    //Big cat
    cheetah, jaguar, leopard, lion, lynx, tiger,
    //Bird
    /*bird, parrot, water_bird,*/
    //Camelids
    /*alpaca, camel,*/
    llama,
    //Crocodile
    /*crocodile,*/
    alligator,
    //Deer
    antelope, /*deer,*/ moose,
    //Flower
    flower, rose, sunflower,
    //Horse
    donkey, /*horse,*/ mule,
    //Insect
    insect, butterfly,
    //Fish
    /*fish, goldfish, jellyfish,*/
    manta_ray, seahorse, /*shellfish,*/ squid,
    //Reptile
    /*reptile, crocodile, turtle,*/
    //Seal
    /*seal,*/
    sea_lion, walrus,
    //Sheep
    goat, /*sheep,*/
    //Shellfish
    crab, lobster, oyster, shrimp, snail, starfish,
    //Turtle
    /*turtle,*/
    sea_turtle, tortoise,
    //Water bird
    duck, goose, swan,
    //Person
    person, human_face, human_hand,
}