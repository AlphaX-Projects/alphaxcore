CC = gcc
CFLAGS = -g -Wall -c -fPIC -O2 -Wno-pointer-sign -Wno-return-type -Wno-char-subscripts -Wno-unused-variable -Wno-uninitialized -Wno-unused-function -Wno-strict-aliasing -Wno-discarded-qualifiers -Wno-unused-const-variable -Wno-implicit-function-declaration -Wno-cpp -msse4 -msse4.1 -msse4.2 -mssse3 -mavx -mpclmul -maes
CXXFLAGS = -g -Wall -fPIC -fpermissive -O2 -Wno-char-subscripts -Wno-unused-variable -Wno-uninitialized -Wno-unused-function -Wno-strict-aliasing -Wno-sign-compare -Wno-cpp -std=c++11 -msse4 -msse4.1 -msse4.2 -mssse3 -mavx -mpclmul -maes
LDFLAGS = -shared
LDLIBS = -lsodium
TARGET  = libmultihash.so

OBJECTS = astralhash.o balloon.o bcrypt.o blake.o blake2s.o c11.o dcrypt.o exports.o fresh.o fugue.o geek.o globalhash.o groestl.o hefty1.o jh.o jeonghash.o \
          KeccakP-800-reference.o keccak.o lane.o Lyra2.o Lyra2-z.o lyra2re.o lyra2v2.o lyra2v3.o lyra2z.o lyra2z330.o lyra2vc0ban.o \
	      neoscrypt.o nist5.o odocrypt.o padihash.o pawelhash.o phi.o phi2.o phi5.o quark.o qubit.o s3.o \
		  scryptn.o sha256.o sha256csm.o sha256-d.o sha256_Y.o shavite3.o skein.o Sponge.o \
	      x11.o x11evo.o x11k.o x11kvs.o x12.o x13.o x14.o x15.o x16r.o x16rt.o x16rv2.o x16s.o x17.o x17r.o x18.o x20r.o x21s.o x22.o x22i.o x25x.o \
		  yescrypt.o yescrypt-opt.o blake2-ref/blake2b.o sha3/SWIFFTX.o sha3/aes_helper.o sha3/extra.o sha3/hamsi_helper.o \
          sha3/sph_blake.o sha3/sph_blake2s.o sha3/sph_bmw.o sha3/sph_cubehash.o sha3/sph_echo.o sha3/sph_fugue.o sha3/sph_gost.o sha3/sph_groestl.o \
          sha3/sph_hamsi.o sha3/sph_haval.o sha3/sph_hefty1.o sha3/sph_jh.o sha3/sph_keccak.o sha3/sph_luffa.o sha3/sph_panama.o \
          sha3/sph_radiogatun.o sha3/sph_ripemd.o sha3/sph_sha2.o sha3/sph_sha2big.o sha3/sph_shabal.o sha3/sph_shavite.o \
          sha3/sph_simd.o sha3/sph_skein.o sha3/sph_sm3.o sha3/sph_tiger.o sha3/sph_whirlpool.o \
	      yespower/yespower-platform.o yespower/yespower-combined.o yespower/yespower-blake2b.o yespower/blake2b-yp.o \
          equi/util.o equi/support/cleanse.o equi/random.o equi/uint256.o equi/arith_uint256.o equi/crypto/hmac_sha512.o \
          equi/crypto/sha1.o equi/crypto/sha512.o equi/crypto/sha256.o equi/crypto/hmac_sha256.o equi/crypto/equihash.o \
	      equi/crypto/ripemd160.o equi/equihashverify.o \
          libethash/internal.o libethash/io.o libethash/io_posix.o libethash/sha3.o \
          verushash/haraka.o verushash/haraka_portable.o verushash/utilstrencodings.o \
          verushash/verus_hash.o verushash/verus_clhash.o verushash/verus_clhash_portable.o

all: $(TARGET)

$(TARGET): $(OBJECTS)
	g++ $(LDFLAGS) -o $@ $^ $(LDLIBS)

.PHONY: clean

clean:
	find . -name '*.o' -exec rm -r {} \;
	rm -f libmultihash.so
