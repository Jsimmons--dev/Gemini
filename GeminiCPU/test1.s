main:
	lda #$100
	sta $0
	add $0
out:
    lda $2        ! x Back into ACC for examination
