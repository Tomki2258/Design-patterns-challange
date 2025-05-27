data class CheeseBurger(val cheese: Int = 5) : IBurger {
    override fun clone(): IBurger {
        return this.copy()
    }
}