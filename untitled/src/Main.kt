fun main() {
    val burger = CheeseBurger();
    println(burger)
    val secondBurger = burger.clone();
    println(secondBurger)

    val chickenBurger = ChickenBurger()
    println(chickenBurger)
    val secondChicken = chickenBurger.clone();
    println(secondChicken)

}