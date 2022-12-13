import math
import random

SIDE_LIMIT = 10
TRIANGLE_COUNT = 10
triangles = {}

def main():
    generate_scalene_triangles()
    generate_isosceles_triangles()
    generate_equilateral_triangles()
    generate_acute_triangles()
    generate_obtuse_triangles()
    generate_right_triangles()
    with open ('triangles_types.txt', 'w') as f:
        for sides, types in triangles.items():
            f.write(str(types) + '\n')

    with open('triangles.txt', 'w') as f:
        for sides, types in triangles.items():
            f.write(str(sides) + '\n')
        

def get_angles(sides):
    a, b, c = sides
    A = math.degrees(math.acos((b**2 + c**2 - a**2) / (2 * b * c)))
    B = math.degrees(math.acos((a**2 + c**2 - b**2) / (2 * a * c)))
    C = math.degrees(math.acos((a**2 + b**2 - c**2) / (2 * a * b)))
    return (A, B, C)

def isValidTriangle(sides):
    a, b, c = sides
    if a + b > c and a + c > b and b + c > a:
        return True
    else:
        return False


'''
generate 100 scalene triangles
A scalene triangle can be defined as a triangle whose all 
three sides have different lengths, and all three angles
are of different measures.
'''
def generate_scalene_triangles():
    count = 0
    while count < TRIANGLE_COUNT:
        # generate random side lengths
        a = random.randint(1, SIDE_LIMIT)
        b = random.randint(1, SIDE_LIMIT)
        while b == a:
            b = random.randint(1, SIDE_LIMIT)
        c = random.randint(1, SIDE_LIMIT)
        while c == a or c == b:
            c = random.randint(1, SIDE_LIMIT)
        sides = (a, b, c)
        if not isValidTriangle(sides):
            continue
        angles = get_angles(sides)
        # all angles must be different
        if angles[0] != angles[1] and angles[0] != angles[2] and angles[1] != angles[2]:
            count += 1
            if sides in triangles:
                if 'scalene' not in triangles[sides]:
                    triangles[sides].append('scalene')
            else:
                triangles[sides] = ['scalene']

'''
generate 100 isosceles triangles
An isosceles triangle can be defined as a triangle whose
two sides have equal lengths, and the two angles opposite
to these sides are equal.
'''
def generate_isosceles_triangles():
    count = 0
    while count < TRIANGLE_COUNT:
        # generate random side lengths
        a = random.randint(1, SIDE_LIMIT)
        b = a
        c = random.randint(1, SIDE_LIMIT)
        while c == a:
            c = random.randint(1, SIDE_LIMIT)
        sides = (a, b, c)
        if not isValidTriangle(sides):
            continue
        angles = get_angles(sides)
        # two angles must be equal
        if angles[0] == angles[1] or angles[0] == angles[2] or angles[1] == angles[2]:
            count += 1
            if sides in triangles:
                if 'isosceles' not in triangles[sides]:
                    triangles[sides].append('isosceles')
            else:
                triangles[sides] = ['isosceles']

'''
generate 100 equilateral triangles
An equilateral triangle can be defined as a triangle whose
all three sides have equal lengths, and all three angles
are of equal measures.
'''
def generate_equilateral_triangles():
    count = 0
    while count < TRIANGLE_COUNT:
        # generate random side lengths
        a = random.randint(1, SIDE_LIMIT)
        b = a
        c = a
        sides = (a, b, c)
        if not isValidTriangle(sides):
            continue
        angles = get_angles(sides)
        # all angles must be equal
        if angles[0] == angles[1] and angles[0] == angles[2] and angles[1] == angles[2]:
            count += 1
            if sides in triangles:
                if 'equilateral' not in triangles[sides]:
                    triangles[sides].append('equilateral')
            else:
                triangles[sides] = ['equilateral']

'''
generate 100 acute triangles
An acute triangle can be defined as a triangle whose all
three angles are less than 90 degrees.
'''
def generate_acute_triangles():
    count = 0
    for triangle in triangles.keys():
        angles = get_angles(triangle)
        if angles[0] < 90 and angles[1] < 90 and angles[2] < 90:
            count += 1
            if 'acute' not in triangles[triangle]:
                triangles[triangle].append('acute')
    while count < TRIANGLE_COUNT:
        # generate random side lengths
        a = random.randint(1, SIDE_LIMIT)
        b = random.randint(1, SIDE_LIMIT)
        c = math.sqrt(a**2 + b**2)
        sides = (a, b, c)
        if not isValidTriangle(sides):
            continue
        angles = get_angles(sides)
        # all angles must be acute
        if angles[0] < 90 and angles[1] < 90 and angles[2] < 90:
            count += 1
            if sides in triangles:
                if 'acute' not in triangles[sides]:
                    triangles[sides].append('acute')
            else:
                triangles[sides] = ['acute']

'''
generate 100 right triangles
A right triangle can be defined as a triangle whose one
angle is 90 degrees.
'''
def generate_right_triangles():
    count = 0
    for triangle in triangles.keys():
        angles = get_angles(triangle)
        if angles[0] == 90 or angles[1] == 90 or angles[2] == 90:
            count += 1
            if 'right' not in triangles[triangle]:
                triangles[triangle].append('right')
    while count < TRIANGLE_COUNT:
        # generate random side lengths
        a = random.randint(1, SIDE_LIMIT)
        b = random.randint(1, SIDE_LIMIT)
        c = math.sqrt(a**2 + b**2)
        sides = (a, b, c)
        if not isValidTriangle(sides):
            continue
        angles = get_angles(sides)
        # one angle must be right
        if angles[0] == 90 or angles[1] == 90 or angles[2] == 90:
            count += 1
            if sides in triangles:
                if 'right' not in triangles[sides]:
                    triangles[sides].append('right')
            else:
                triangles[sides] = ['right']

'''
generate 100 obtuse triangles
An obtuse triangle can be defined as a triangle whose one
angle is greater than 90 degrees.
'''
def generate_obtuse_triangles():
    count = 0
    for triangle in triangles.keys():
        angles = get_angles(triangle)
        if angles[0] > 90 or angles[1] > 90 or angles[2] > 90:
            count += 1
            if 'obtuse' not in triangles[triangle]:
                triangles[triangle].append('obtuse')
    while count < TRIANGLE_COUNT:
        # generate random side lengths
        a = random.randint(1, SIDE_LIMIT)
        b = random.randint(1, SIDE_LIMIT)
        c = math.sqrt(a**2 + b**2)
        sides = (a, b, c)
        if not isValidTriangle(sides):
            continue
        angles = get_angles(sides)
        # one angle must be obtuse
        if angles[0] > 90 or angles[1] > 90 or angles[2] > 90:
            count += 1
            if sides in triangles:
                if 'obtuse' not in triangles[sides]:
                    triangles[sides].append('obtuse')
            else:
                triangles[sides] = ['obtuse']




if __name__ == "__main__":
    main()