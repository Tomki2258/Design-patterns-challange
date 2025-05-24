fun main() {
    val enemiesList : List<Enemy>  = arrayListOf(
        Enemy(5,5,1),
        Enemy(3,1,2),
        Enemy(25,25,3),
        Enemy(10000,25,4),
        Enemy(1,1,5)
    )

    val hero = Hero(enemiesList)
    hero.update()
}