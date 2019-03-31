# HEARTBEAT ENGINE

The Main Skeleton:
    1. Engine (Contains Logic)
    2. Window (Seperated WinForms stuff, will get passed to engine)
    3. Main Loader (Creates Window pass it to engine, along with any variables)

Base Systems:
    Events:
        1. Event (Specialized code for encounters, towns, etc, whatever I feel like)
    Controls:
        1. Event Handler (Reads keyboard inputs and executes appropriate methods, tied to specific events, entites, IGOs)
    IGO System:
        1. Bounding Boxes (Collisions methods and Sizes)
        2. Entity (Inherits from BB, contains all relevant information for base in game objects)
        3. Statics (Static objects in the game. Ie. Walls, platforms, or visual objects like tress etc)
    Worldspace:
        2D "TextWorld" Version:
            1. Rooms (Spaces of the world containg IGOs, events, etc)
            2. Maps (Contains rooms in a given width x height list)
            3. World (Contains a map, controls, player IGO)
        2D "Mapping" Version:
            1. Maps (Image files to be read from pixel by pixel to create and position Entities and IGOs)
            2. Reading System (Reads pixels and creates relevant Entites/IGOs, events)
        2D "Grid" System:
            1. World (Width x height create a grid from those values at size ie. 640x640 world size 32)
            2. Snapping (Intercept control class and adjust values by the grid)
