1. Inheritance was utilized since all transport type are identified as Vehicle, which they share the same behavior like using the Move() method. It avoids the need for duplication of common codes to be used.

2. Interfaces are used since they represent on what an object is assigned/capable to do. It makes assigning of interfaces to their respective classes much easier. 

3. No it can't. It is only allowed to inherit from one class because multiple inheritance is not allowed in this case. For example, in this case, the Helicopter class can only inherit from Vehicle. But it is not allowed to inherit from Airplane as well. Instead, assigning multiple interfaces in a class is usually done

4. Because it is allowed to assign multiple interfaces in one class, which means a class can be assigned multiple tasks/abilities. In our case, the Helicopter can both drive and fly. Hence, the IDriveable and IFlyable interfaces were assigned to the Helicopter class.

5. I would create the Submarine class first which inherits the Vehicle, ISailable, and IDiveable. But there is no IDiveable interface yet, so that would also need to be created. Basically it would use the same structure as the Helicopter class.