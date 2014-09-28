main:
    lda #$3
    sta $0 ! store 3 into $0 = x

    lda #$0
    sta $1 ! store 0 into $1 = y

for1:
    lda $1
    be rehash
    lda #$2
    sta $2 ! store 2 into $2 = z
    lda $0
    div $2
    sta $1
    lda $2
    add $0
    sta $2
    lda #$9
    sta $3
    lda $1
    sub $3
    be if
    ba for1
if:
    lda $2
    mul #$256
    sta $4 !z*256
    lda $0
    mul #$257
    add $4
    sta $1
    ba rehash

rehash:

lda $1
and $0
sta $2 ! y&x
lda $1
or $0
sta $3 ! x|y
and $2
sta $1

out:
