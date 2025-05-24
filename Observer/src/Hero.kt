import kotlin.math.sqrt

//HERO IS AT X:0 0
class Hero(var enemiesList: List<Enemy>) {
    fun update() {
        for (enemy in enemiesList) {
            val enemyX = enemy.x
            val enemyY = enemy.y

            val result = sqrt(
                Math.pow((0 - enemyX).toDouble(), 2.0)
                        + Math.pow((0 - enemyY).toDouble(), 2.0)
            )

            enemy.update(result)
        }
    }

}