// Empty project init
import android.os.Bundle
import android.widget.Button
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val btn = findViewById<Button>(R.id.btnHello)
        btn.setOnClickListener {
            Toast.makeText(this, "xin chào", Toast.LENGTH_SHORT).show()
        }
    }
}
