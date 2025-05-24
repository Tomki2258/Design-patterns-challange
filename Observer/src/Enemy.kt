class Enemy(var x: Int, var y: Int, var index: Int) : IEnemy {
    var attackRange = 5

    override fun update(distance: Double) {
        if (distance < attackRange){
            println("Przeciwnik NR.${index} może atakować !")
        }
    }
}