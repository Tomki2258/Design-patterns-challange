data class ChickenBurger(val chicken :Int = 5): IBurger {
    override fun clone(): IBurger {
        return this.copy();
    }
}