extends Camera2D

export var speed = 40

func _process(delta):
	var position = Vector2(speed * delta, 0)
	self.position += position
